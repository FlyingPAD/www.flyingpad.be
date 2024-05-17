using MB.Domain.Common;

namespace MB.Domain.Entities;

public class Task : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime DateStart { get; set; } = DateTime.MinValue;
    public DateTime DateEnd { get; set; } = DateTime.MinValue;
    public int TaskCategoryId { get; set; } = 0;
    public TaskCategory TaskCategory { get; set; } = default!;
}