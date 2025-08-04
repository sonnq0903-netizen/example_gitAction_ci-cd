// Model/Todo.cs
namespace SourceExample.Model;

public class TodoItem
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public bool IsDone { get; set; }
}
