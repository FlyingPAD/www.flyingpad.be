using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;

namespace MB.Application.Contracts.Persistence;

public interface ITaskCategoryRepository : IBaseRepository<TaskCategory>
{
    Task<List<TaskCategory>> GetTaskCategoriesWithTasks(bool includePastTasks);
}
