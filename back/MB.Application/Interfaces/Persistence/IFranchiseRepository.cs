using MB.Application.Features.Franchises.Queries.GetFranchisesCheckBoxesByModel;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;

namespace MB.Application.Interfaces.Persistence;

public interface IFranchiseRepository : IBaseRepository<Franchise>
{
    Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds);
    Task<List<Franchise>> GetFranchisesByModels(List<int> modelId);
    Task<List<Franchise>> GetFranchisesByMedia(int? mediaId);
    Task<IEnumerable<GetFranchisesCheckBoxesByModelQueryDto>> GetCheckBoxesByModel(int modelId);
    Task<Franchise?> GetFranchiseWithMediaAsync(int franchiseId);
    System.Threading.Tasks.Task AddMediaAsync(int franchiseId, IEnumerable<int> mediaIds);
    System.Threading.Tasks.Task RemoveMediaAsync(Franchise franchise);
}