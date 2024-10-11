namespace MB.Application.Features.Tasks.Queries.GetTaskDetails;

public class TaskDetailsVm
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime DateStart { get; set; }
    public DateTime DateEnd { get; set; }
    public Guid TaskCategoryId { get; set; }
    public TaskCategoryDto TaskCategory { get; set; } = default!;
}