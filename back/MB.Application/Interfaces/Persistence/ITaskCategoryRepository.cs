using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;

namespace MB.Application.Interfaces.Persistence;

public interface ITaskCategoryRepository : IBaseRepository<TaskCategory>
{
    Task<List<TaskCategory>> GetTaskCategoriesWithTasks(bool includePastTasks);
}
