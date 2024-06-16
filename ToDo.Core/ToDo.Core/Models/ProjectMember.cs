namespace ToDo.Core.Models;

public class ProjectMember
{
    public Guid IdProject { get; set; }

    public Guid IdUser { get; set; }

    public Guid IncludedBy { get; set; }

    public DateTime IncludedAt { get; set; }

    public bool ChangeProject { get; set; }

    public bool CreateTasks { get; set; }

    public bool ChangeTasks { get; set; }

    public bool ChangeTasksStatus { get; set; }

    public bool CreateBuckets { get; set; }

    public bool ChangeTasksBucket { get; set; }

    public bool CreateTags { get; set; }

    public bool ChangeTasksTags { get; set; }

    public Project Project { get; set; } = null!;

    public User User { get; set; } = null!;

    public User? IncludedUser { get; set; }

}