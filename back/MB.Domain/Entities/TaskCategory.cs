using MB.Domain.Common;

namespace MB.Domain.Entities;

public class TaskCategory : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public ICollection<Task> Tasks { get; set; } = [];
}
