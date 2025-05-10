using MB.Application.Features.Franchises.Queries.GetFranchisesCheckBoxesByModel;
using MB.Application.Interfaces.Persistence;
using MB.Domain.FranchiseAggregate;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories.Definitions;

public class FranchiseRepository(Context context) : BaseRepository<Franchise>(context), IFranchiseRepository
{
    public async Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds)
    {
        return await _context.Franchises
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

    public async Task<Franchise?> GetFranchiseWithMediaAsync(int franchiseId)
    {
        return await _context.Franchises
            .Include(franchise => franchise.FranchiseMedias)
            .FirstOrDefaultAsync(franchise => franchise.EntityId == franchiseId);
    }

    public async Task RemoveMediaAsync(Franchise franchise)
    {
        _context.RFranchiseMedia.RemoveRange(franchise.FranchiseMedias ?? []);
        await _context.SaveChangesAsync();
    }

    public async Task AddMediaAsync(int franchiseId, IEnumerable<int> mediaIds)
    {
        var relationsToAdd = mediaIds.Select(mediumId => new RelationFranchiseMedia
        {
            FranchiseId = franchiseId,
            MediaId = mediumId
        }).ToList();

        _context.RFranchiseMedia.AddRange(relationsToAdd);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<GetFranchisesCheckBoxesByModelQueryDto>> GetCheckBoxesByModel(int modelId)
    {
        var franchises = await _context.Franchises
            .Select(franchise => new GetFranchisesCheckBoxesByModelQueryDto
            {
                BusinessId = franchise.BusinessId,
                Name = franchise.Name,
                IsChecked = franchise.FranchiseModels != null && franchise.FranchiseModels
                    .Any(relation => relation.ModelId == modelId)
            })
            .OrderBy(franchise => franchise.Name)
            .ToListAsync();

        return franchises;
    }
}