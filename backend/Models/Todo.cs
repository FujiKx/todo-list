namespace TodoApi.Models;

public class Todo
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsComleted { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}