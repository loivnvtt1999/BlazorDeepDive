using BlazorDeepDive.Components;
using BlazorDeepDive.Data;
using BlazorDeepDive.Models;
using BlazorDeepDive.StateStore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace BlazorDeepDive
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContextFactory<ServerManagementContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("ServerManagement"));
            });
            // Add services to the container.
            builder.Services.AddRazorComponents().AddInteractiveServerComponents();
            builder.Services.AddTransient<SessionStorage>();
            builder.Services.AddScoped<ContainerStorage>();
            builder.Services.AddScoped<TorontoOnlineServerStore>();
            builder.Services.AddScoped<HalifaxOnlineServersStore>();
            builder.Services.AddScoped<MontrealOnlineServersStore>();
            builder.Services.AddScoped<CalgaryOnlineServersStore>();
            builder.Services.AddScoped<OttawaOnlineServersStore>();
            builder.Services.AddTransient<IServersEFCoreRepository, ServersEFCoreRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
