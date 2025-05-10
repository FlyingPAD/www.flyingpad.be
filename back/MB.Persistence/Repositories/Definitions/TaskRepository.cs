using MB.Application.Interfaces.Persistence;

namespace MB.Persistence.Repositories.Definitions
{
    public class TaskRepository(Context context) : BaseRepository<Domain.TaskAggregate.Task>(context), ITaskRepository
    {
        public Task<bool> IsTaskNameAndDateUnique(string name, DateTime taskDateStart)
        {
            var matches = _context.Tasks.Any(e => e.Name.Equals(name) && e.DateStart.Date.Equals(taskDateStart.Date));
            return Task.FromResult(matches);
        }
    }
}