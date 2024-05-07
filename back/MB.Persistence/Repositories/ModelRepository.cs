using MB.Application.Contracts.Persistence;
using MB.Application.Features.Tags.Queries.GetTagsByMood;
using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories
{
    public class ModelRepository(Context context) : BaseRepository<Model>(context), IModelRepository
    {
        public async Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds)
        {
            // Use LINQ to query styles by business ID and select their entity ID.

            return await _context.Models
                                 .Where(model => businessIds.Contains(model.BusinessId))
                                 .Select(model => model.EntityId)
                                 .ToListAsync();
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