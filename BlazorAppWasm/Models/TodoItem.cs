namespace BlazorAppWasm.Models
{
    public class TodoItem
    {
        public Category? Category { get; set; }
        public Guid CategoryId { get; set; }
        public string? Task { get; set; }
        public bool IsDone { get; set; }
    }

    // https://dribbble.com/shots/14100356-ToDo-App-UI
}
