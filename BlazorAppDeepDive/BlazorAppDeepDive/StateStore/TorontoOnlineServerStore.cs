namespace BlazorDeepDive.StateStore
{
    public class TorontoOnlineServerStore : Observer
    {
        private int _numberOfOnlineServers;
        public int GetNumberOfOnlineServers() => _numberOfOnlineServers;

        public void SetNumberOfOnlineServers(int numberOfOnlineServers)
        {
            _numberOfOnlineServers = numberOfOnlineServers;
            BroadcastStateChange();
        }
    }
}
