using MB.Application.Features.Franchises.Queries.GetFranchisesCheckBoxesByModel;
using MB.Domain.FranchiseAggregate;

namespace MB.Application.Interfaces.Persistence.Definitions;

public interface IFranchiseRepository : IBaseRepository<Franchise>
{
    Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds);
    Task<List<Franchise>> GetFranchisesByModels(List<int> modelId);
    Task<List<Franchise>> GetFranchisesByMedia(int? mediaId);
    Task<IEnumerable<GetFranchisesCheckBoxesByModelQueryDto>> GetCheckBoxesByModel(int modelId);
    Task<Franchise?> GetFranchiseWithMediaAsync(int franchiseId);
    Task AddMediaAsync(int franchiseId, IEnumerable<int> mediaIds);
    Task RemoveMediaAsync(Franchise franchise);
}