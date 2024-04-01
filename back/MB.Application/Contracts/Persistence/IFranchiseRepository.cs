using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;

namespace MB.Application.Contracts.Persistence
{
    public interface IFranchiseRepository : IBaseRepository<Franchise>
    {
        Task<List<Franchise>> GetFranchisesByModels(List<int> modelId);
    }
}