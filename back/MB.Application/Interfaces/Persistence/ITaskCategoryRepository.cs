using MB.Domain.TaskCategoryAggregate;

namespace MB.Application.Interfaces.Persistence;

public interface ITaskCategoryRepository : IBaseRepository<TaskCategory>
{
    Task<List<TaskCategory>> GetTaskCategoriesWithTasks(bool includePastTasks);
}
