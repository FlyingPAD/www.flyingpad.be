using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;

namespace MB.Application.Interfaces.Persistence;

public interface IFranchiseRepository : IBaseRepository<Franchise>
{
    Task<List<Franchise>> GetFranchisesByModels(List<int> modelId);
    Task<List<Franchise>> GetFranchisesByMedia(int? mediaId);
    System.Threading.Tasks.Task UpdateMedias(int franchiseId, ICollection<int> mediasIds);
    Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds);
}