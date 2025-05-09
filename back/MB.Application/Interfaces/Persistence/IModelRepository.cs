﻿using MB.Application.Features.Models.Queries.GetModelCheckBoxesByMood;
using MB.Domain.ModelAggregate;

namespace MB.Application.Interfaces.Persistence;

public interface IModelRepository : IBaseRepository<Model>
{
    Task<IEnumerable<Model>> GetModelsByMood(int? moodId);
    Task<IEnumerable<Model>> GetModelsByFranchise(int? franchiseId);
    Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> modelIds);
    Task<IEnumerable<GetModelCheckBoxesByMoodQueryDto>> GetModelsCheckBoxesByMood(int moodId);
    System.Threading.Tasks.Task UpdateFranchises(int modelId, ICollection<int> franchiseIds);
    System.Threading.Tasks.Task AddFranchisesAsync(int modelId, IEnumerable<int> franchisesIds);
    System.Threading.Tasks.Task RemoveFranchisesAsync(Model model);
    Task<Model?> GetModelWithFranchisesAsync(int modelId);
}