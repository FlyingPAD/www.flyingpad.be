using MB.Application.Interfaces.Persistence.Common;

namespace MB.Application.Interfaces.Persistence;

public interface ITaskRepository : IBaseRepository<Domain.Entities.Task>
{
    Task<bool> IsTaskNameAndDateUnique(string name, DateTime taskDateStart);
}
