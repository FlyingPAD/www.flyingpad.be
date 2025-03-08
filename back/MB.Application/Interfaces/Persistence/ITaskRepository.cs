namespace MB.Application.Interfaces.Persistence;

public interface ITaskRepository : IBaseRepository<Domain.TaskAggregate.Task>
{
    Task<bool> IsTaskNameAndDateUnique(string name, DateTime taskDateStart);
}
