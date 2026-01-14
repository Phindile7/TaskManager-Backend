namespace TaskManager.Models;

public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public bool Completed { get; set; } = false;

    public int UserId { get; set; } 
    public User? User { get; set; }
}
