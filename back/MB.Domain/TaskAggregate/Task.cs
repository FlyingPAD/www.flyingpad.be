using MB.Domain.TaskCategoryAggregate;

namespace MB.Domain.TaskAggregate;

public class Task : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime DateStart { get; set; } = DateTime.UtcNow;
    public DateTime DateEnd { get; set; } = DateTime.UtcNow;
    public int TaskCategoryId { get; set; }
    public TaskCategory TaskCategory { get; set; } = default!;
}