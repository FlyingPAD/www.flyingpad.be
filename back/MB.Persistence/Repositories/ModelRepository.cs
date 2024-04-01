using MB.Application.Contracts.Persistence;
using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories
{
    public class ModelRepository : BaseRepository<Model>, IModelRepository
    {
        public ModelRepository(Context context) : base(context)
        {
        }

        public async Task<List<Model>> GetModelsByMood(int? moodId)
        {
            return await _context.Models
                .Where(model => model.MoodModels != null && model.MoodModels.Any(relation => relation.MoodId == moodId))
                .OrderBy(model => model.Pseudonym)
                .ToListAsync();
        }

        public async Task<List<Model>> GetModelsByFranchise(int? franchiseId)
        {
            return await _context.Models
                .Where(model => model.FranchiseModels != null && model.FranchiseModels.Any(relation => relation.FranchiseId == franchiseId))
                .OrderBy(model => model.Pseudonym)
                .ToListAsync();
        }
    }
}