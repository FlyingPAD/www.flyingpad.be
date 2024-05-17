using MediatR;

namespace MB.Application.Features.TaskCategories.Queries.GetTaskCategoriesListWithTasks;

public class GetTaskCategoriesListWithTasksQuery : IRequest<List<TaskCategoryTaskListVm>>
{
    public bool IncludeHistory { get; set; }
}
