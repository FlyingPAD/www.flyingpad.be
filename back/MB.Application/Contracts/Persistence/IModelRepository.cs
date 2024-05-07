using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;

namespace MB.Application.Contracts.Persistence
{
    public interface IModelRepository : IBaseRepository<Model>
    {
        Task<List<Model>> GetModelsByMood(int? moodId);
        Task<List<Model>> GetModelsByFranchise(int? franchiseId);
        Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> modelIds);
    }
}