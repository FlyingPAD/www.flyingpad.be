namespace MB.Application.Features.Tasks.Queries.GetTasksList;

public class TasksListVm
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime DateStart { get; set; }
}
