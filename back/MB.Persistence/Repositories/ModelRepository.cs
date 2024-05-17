using MB.Application.Contracts.Persistence;
using MB.Application.Features.Models.Queries.GetModelCheckBoxesByMood;
using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories;

public class ModelRepository(Context context) : BaseRepository<Model>(context), IModelRepository
{
    /// <summary>
    /// Gets the primary IDs by business IDs.
    /// </summary>
    public async Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds)
    {
        return await _context.Models
                             .Where(model => businessIds.Contains(model.BusinessId))
                             .Select(model => model.EntityId)
                             .ToListAsync();
    }

    /// <summary>
    /// Gets models by mood ID.
    /// </summary>
    public async Task<IEnumerable<Model>> GetModelsByMood(int? moodId)
    {
        return await _context.Models
                            .Where(model => model.MoodModels != null && model.MoodModels.Any(relation => relation.MoodId == moodId))
                            .OrderBy(model => model.Pseudonym)
                            .ToListAsync();
    }

    /// <summary>
    /// Gets models by franchise ID.
    /// </summary>
    public async Task<IEnumerable<Model>> GetModelsByFranchise(int? franchiseId)
    {
        return await _context.Models
                            .Where(model => model.FranchiseModels != null && model.FranchiseModels.Any(relation => relation.FranchiseId == franchiseId))
                            .OrderBy(model => model.Pseudonym)
                            .ToListAsync();
    }

    /// <summary>
    /// Gets model checkboxes by mood ID.
    /// </summary>
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

    /// <summary>
    /// Updates the set of franchises associated with a specific Model.
    /// </summary>
    public async System.Threading.Tasks.Task UpdateFranchises(int modelId, ICollection<int> franchiseIds)
    {
        var model = await _context.Models
                                 .Include(m => m.FranchiseModels)
                                 .FirstOrDefaultAsync(model => model.EntityId == modelId) ?? throw new ArgumentException("No model found with the provided ID.", nameof(modelId));

        var existingFranchiseIds = model.FranchiseModels?.Select(relation => relation.FranchiseId).ToList() ?? [];

        var franchisesToAdd = franchiseIds.Except(existingFranchiseIds).ToList();
        foreach (var franchiseId in franchisesToAdd)
        {
            _context.RFranchiseModel.Add(new RelationFranchiseModel { ModelId = modelId, FranchiseId = franchiseId });
        }

        var franchisesToRemove = existingFranchiseIds.Except(franchiseIds).ToList();
        foreach (var franchiseId in franchisesToRemove)
        {
            var franchiseToRemove = model.FranchiseModels?.FirstOrDefault(relation => relation.FranchiseId == franchiseId);
            if (franchiseToRemove != null)
                _context.RFranchiseModel.Remove(franchiseToRemove);
        }

        await _context.SaveChangesAsync();
    }
}
