using MB.Application.Contracts.Persistence;
using MB.Application.Features.Models.Queries.GetModelCheckBoxesByMood;
using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories
{
    public class ModelRepository(Context context) : BaseRepository<Model>(context), IModelRepository
    {
        public async Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds)
        {
            return await _context.Models
                                 .Where(model => businessIds.Contains(model.BusinessId))
                                 .Select(model => model.EntityId)
                                 .ToListAsync();
        }

        public async Task<IEnumerable<Model>> GetModelsByMood(int? moodId)
        {
            return await _context.Models
                                .Where(model => model.MoodModels != null && model.MoodModels.Any(relation => relation.MoodId == moodId))
                                .OrderBy(model => model.Pseudonym)
                                .ToListAsync();
        }

        public async Task<IEnumerable<Model>> GetModelsByFranchise(int? franchiseId)
        {
            return await _context.Models
                                .Where(model => model.FranchiseModels != null && model.FranchiseModels.Any(relation => relation.FranchiseId == franchiseId))
                                .OrderBy(model => model.Pseudonym)
                                .ToListAsync();
        }

        public async Task<IEnumerable<GetModelCheckBoxesByMoodQueryDto>> GetModelsCheckBoxesByMood(int moodId)
        {
            var models = await _context.Models
                                       .Select(model => new GetModelCheckBoxesByMoodQueryDto
                                       {
                                           BusinessId = model.BusinessId,
                                           Pseudonym = model.Pseudonym,
                                           IsChecked = model.MoodModels != null && model.MoodModels.Any(mm => mm.MoodId == moodId)
                                       })
                                       .OrderBy(model => model.Pseudonym)
                                       .ToListAsync();

            return models;
        }

    }
}