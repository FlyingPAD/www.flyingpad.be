namespace MB.Domain.TaskCategoryAggregate;

public class TaskCategory : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public ICollection<TaskAggregate.Task> Tasks { get; set; } = [];
}