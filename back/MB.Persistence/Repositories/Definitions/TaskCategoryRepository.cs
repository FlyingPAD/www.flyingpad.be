using MB.Application.Interfaces.Persistence.Definitions;
using MB.Domain.TaskCategoryAggregate;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories.Definitions;

public class TaskCategoryRepository(Context context) : BaseRepository<TaskCategory>(context), ITaskCategoryRepository
{
    public async Task<List<TaskCategory>> GetTaskCategoriesWithTasks(bool includePastEvents)
    {
        var allTaskCategories = await _context.TaskCategories.Include(x => x.Tasks).ToListAsync();

        if (!includePastEvents)
        {
            foreach (var category in allTaskCategories)
            {
                if (category.Tasks != null)
                {
                    category.Tasks = category.Tasks.Where(task => task.DateStart >= DateTime.Today).ToList();
                }
            }
        }

        return allTaskCategories;
    }
}