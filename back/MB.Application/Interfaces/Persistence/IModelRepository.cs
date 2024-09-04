using MB.Application.Features.Models.Queries.GetModelCheckBoxesByMood;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;

namespace MB.Application.Interfaces.Persistence;

public interface IModelRepository : IBaseRepository<Model>
{
    Task<IEnumerable<Model>> GetModelsByMood(int? moodId);
    Task<IEnumerable<Model>> GetModelsByFranchise(int? franchiseId);
    Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> modelIds);
    Task<IEnumerable<GetModelCheckBoxesByMoodQueryDto>> GetModelsCheckBoxesByMood(int moodId);
    System.Threading.Tasks.Task UpdateFranchises(int modelId, ICollection<int> franchiseIds);
    System.Threading.Tasks.Task DeleteModelRelations(int modelId);
}