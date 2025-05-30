using MB.Domain.TaskCategoryAggregate;

namespace MB.Application.Interfaces.Persistence.Definitions;

public interface ITaskCategoryRepository : IBaseRepository<TaskCategory>
{
    Task<List<TaskCategory>> GetTaskCategoriesWithTasks(bool includePastTasks);
}
