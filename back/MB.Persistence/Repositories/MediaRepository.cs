using MB.Application.Features.Medias.Queries;
using MB.Application.Interfaces.Persistence;
using MB.Domain.MediumAggregate;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories;

public class MediaRepository(Context context) : BaseRepository<Media>(context), IMediaRepository
{
    public async Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds)
    {
        return await _context.Medias
                             .Where(media => businessIds.Contains(media.BusinessId))
                             .Select(media => media.EntityId)
                             .ToListAsync();
    }

    public async Task<IEnumerable<GetMediaCheckBoxesByFranchiseQueryDto>> GetCheckBoxesByFranchise(int franchiseId)
    {
        var media = await _context.Medias
            .Select(media => new GetMediaCheckBoxesByFranchiseQueryDto
            {
                BusinessId = media.BusinessId,
                Name = media.Name,
                IsChecked = media.FranchiseMedias != null && media.FranchiseMedias
                    .Any(relation => relation.FranchiseId == franchiseId)
            })
            .OrderBy(media => media.Name)
            .ToListAsync();

        return media;
    }
}