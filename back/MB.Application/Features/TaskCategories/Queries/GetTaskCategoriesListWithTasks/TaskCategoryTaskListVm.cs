namespace MB.Application.Features.TaskCategories.Queries.GetTaskCategoriesListWithTasks
{
    public class TaskCategoryTaskListVm
    {
        public Guid BusinessId { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<TaskCategoryTaskDto>? Tasks { get; set; }
    }
}
