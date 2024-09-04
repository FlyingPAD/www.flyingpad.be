using MB.Application.Interfaces.Persistence;
using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;
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
}
