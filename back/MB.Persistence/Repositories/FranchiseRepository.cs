using MB.Application.Contracts.Persistence;
using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories
{
    public class FranchiseRepository(Context context) : BaseRepository<Franchise>(context), IFranchiseRepository
    {
        public async Task<List<Franchise>> GetFranchisesByMedia(int? mediaId)
        {
            return await _context.Franchises
                .Where(franchise => franchise.FranchiseMedias != null && franchise.FranchiseMedias.Any(relation => relation.MediaId == mediaId))
                .OrderBy(franchise => franchise.Name)
                .ToListAsync();
        }

        public async Task<List<Franchise>> GetFranchisesByModels(List<int> modelIds)
        {
            var franchises = await _context.Franchises
                .AsNoTracking()
                .Include(f => f.FranchiseModels)
                .Where(f => f.FranchiseModels != null && f.FranchiseModels.Any(fm => modelIds.Contains(fm.ModelId)))
                .ToListAsync();

            return franchises ?? [];
        }
    }
}