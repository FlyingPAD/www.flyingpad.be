namespace MB.Application.Features.TaskCategories.Queries.GetTaskCategoriesListWithTasks;

public class TaskCategoryTaskDto
{
    public Guid TaskId { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime DateStart { get; set; }
    public Guid TaskCategoryId { get; set; }
}
