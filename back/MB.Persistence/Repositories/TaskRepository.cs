using MB.Application.Contracts.Persistence;
using MB.Persistence.Repositories.Common;

namespace MB.Persistence.Repositories
{
    public class TaskRepository(Context context) : BaseRepository<MB.Domain.Entities.Task>(context), ITaskRepository
    {
        public Task<bool> IsTaskNameAndDateUnique(string name, DateTime taskDateStart)
        {
            var matches = _context.Tasks.Any(e => e.Name.Equals(name) && e.DateStart.Date.Equals(taskDateStart.Date));

            return Task.FromResult(matches);
        }
    }
}
