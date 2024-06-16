namespace ToDo.Core.Models;

public class Bucket
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }

    public string CreatedBy { get; set; } = string.Empty;

    public Guid ProjectId { get; set; }

    public Project Projetc { get; set; } = null!;

    public User CreateUser { get; set; } = null!;
}
