using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Models.Queries.GetModelCheckBoxesByMood;
using MB.Domain.Entities;

namespace MB.Application.Contracts.Persistence
{
    public interface IModelRepository : IBaseRepository<Model>
    {
        Task<IEnumerable<Model>> GetModelsByMood(int? moodId);
        Task<IEnumerable<Model>> GetModelsByFranchise(int? franchiseId);
        Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> modelIds);
        Task<IEnumerable<GetModelCheckBoxesByMoodQueryDto>> GetModelsCheckBoxesByMood(int moodId);
    }
}