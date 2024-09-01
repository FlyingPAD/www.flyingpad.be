using MB.Application.Contracts.Persistence;
using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories;

public class FranchiseRepository(Context context) : BaseRepository<Franchise>(context), IFranchiseRepository
{
    public async Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds)
    {
        return await _context.Artists
                             .Where(franchise => businessIds.Contains(franchise.BusinessId))
                             .Select(franchise => franchise.EntityId)
                             .ToListAsync();
    }

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

    public async System.Threading.Tasks.Task UpdateMedias(int franchiseId, ICollection<int> mediasIds)
    {
        var franchise = await _context.Franchises
                                 .Include(franchise => franchise.FranchiseMedias)
                                 .FirstOrDefaultAsync(franchise => franchise.EntityId == franchiseId) ?? throw new ArgumentException("No franchise found with the provided ID.", nameof(franchiseId));

        var existingMediasIds = franchise.FranchiseMedias?.Select(relation => relation.MediaId).ToList() ?? [];

        var mediasToAdd = mediasIds.Except(existingMediasIds).ToList();
        foreach (var mediaId in mediasToAdd)
        {
            _context.RFranchiseMedia.Add(new RelationFranchiseMedia { FranchiseId = franchiseId, MediaId = mediaId });
        }

        var mediasToRemove = existingMediasIds.Except(mediasIds).ToList();
        foreach (var mediaId in mediasToRemove)
        {
            var mediaToRemove = franchise.FranchiseMedias?.FirstOrDefault(relation => relation.MediaId == mediaId);
            if (mediaToRemove != null)
                _context.RFranchiseMedia.Remove(mediaToRemove);
        }

        await _context.SaveChangesAsync();
    }
}
