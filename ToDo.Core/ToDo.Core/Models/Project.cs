namespace ToDo.Core.Models;

public class Project
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid UpdatedBy { get; set; }

    public Guid StatusId { get; set; }

    public Status Status { get; set; } = null!;

    public List<Bucket> Buckets { get; set; } = new();

    public List<User> Users { get; set; } = new();

    public User CreateUser { get; set; } = null!;

    public User? UpdateUser { get; set; }
}