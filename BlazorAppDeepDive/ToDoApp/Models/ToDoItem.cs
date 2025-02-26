namespace ToDoApp.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool _isCompleted { get; set; }
        public bool IsCompleted
        {
            get => _isCompleted; 
            set
            {
                _isCompleted = value;
                if (value)
                {
                    DateCompleted = DateTime.Now;
                }
                else
                {
                    DateCompleted = DateTime.MinValue;
                }
            }
        }
        public DateTime DateCompleted { get; set; }
    }
}
