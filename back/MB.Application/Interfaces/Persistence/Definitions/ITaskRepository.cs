namespace MB.Application.Interfaces.Persistence.Definitions;

public interface ITaskRepository : IBaseRepository<Domain.TaskAggregate.Task>
{
    Task<bool> IsTaskNameAndDateUnique(string name, DateTime taskDateStart);
}
