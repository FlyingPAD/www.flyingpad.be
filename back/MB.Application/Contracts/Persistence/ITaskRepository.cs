using MB.Application.Contracts.Persistence.Common;

namespace MB.Application.Contracts.Persistence
{
    public interface ITaskRepository : IBaseRepository<MB.Domain.Entities.Task>
    {
        Task<bool> IsTaskNameAndDateUnique(string name, DateTime taskDateStart);
    }
}
