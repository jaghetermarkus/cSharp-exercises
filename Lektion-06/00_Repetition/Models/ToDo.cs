namespace _00_Repetition.Models;

public class ToDo
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Activity { get; set; } = null!;
    public DateTime Created { get; set; } = DateTime.Now;
}

