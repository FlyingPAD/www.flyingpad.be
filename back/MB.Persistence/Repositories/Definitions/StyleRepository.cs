using MB.Application.Features.Styles.Queries.GetStylesCheckBoxesByArtist;
using MB.Application.Interfaces.Persistence.Definitions;
using MB.Domain.StyleAggregate;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories.Definitions;

public class StyleRepository(Context context) : BaseRepository<Style>(context), IStyleRepository
{
    public async Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds)
    {
        return await _context.Styles
                        .Where(style => businessIds.Contains(style.BusinessId))
                        .Select(style => style.EntityId)
                        .ToListAsync();
    }

    public async Task<IEnumerable<GetStylesCheckBoxesByArtistQueryDto>> GetCheckBoxesByArtist(int artistId)
    {
        var styles = await _context.Styles
            .Select(style => new GetStylesCheckBoxesByArtistQueryDto
            {
                BusinessId = style.BusinessId,
                Name = style.Name,
                IsChecked = style.ArtistStyles != null && style.ArtistStyles
                    .Any(relation => relation.ArtistId == artistId)
            })
            .OrderBy(style => style.Name)
            .ToListAsync();

        return styles;
    }
}