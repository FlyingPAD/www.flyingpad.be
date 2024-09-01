using MB.Application.Contracts.Persistence;
using MB.Application.Features.Styles.Queries.GetStylesCheck;
using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories;

public class StyleRepository(Context context) : BaseRepository<Style>(context), IStyleRepository
{
    public async Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds)
    {
        return await _context.Styles
                             .Where(style => businessIds.Contains(style.BusinessId))
                             .Select(style => style.EntityId)
                             .ToListAsync();
    }

    public async Task<List<GetStylesCheckQueryDto>> GetStylesWithCheck(Guid artistGuid)
    {
        var stylesWithCheck = await (from style in _context.Styles
                                     join rArtistStyle in _context.RArtistStyle on style.EntityId equals rArtistStyle.StyleId into styleGroup
                                     from subStyle in styleGroup.DefaultIfEmpty()
                                     join artist in _context.Artists on subStyle.ArtistId equals artist.EntityId into artistGroup
                                     from subArtist in artistGroup.DefaultIfEmpty()
                                     where subArtist.BusinessId == artistGuid || artistGuid == Guid.Empty
                                     select new GetStylesCheckQueryDto
                                     {
                                         BusinessId = style.BusinessId,
                                         Name = style.Name,
                                         IsChecked = subArtist != null && subArtist.BusinessId == artistGuid
                                     }).ToListAsync();

        return stylesWithCheck;
    }

    public async System.Threading.Tasks.Task DeleteArtists(int styleId)
    {
        var relations = await _context.RArtistStyle
                                     .Where(relation => relation.StyleId == styleId)
                                     .ToListAsync();

        _context.RArtistStyle.RemoveRange(relations);

        await _context.SaveChangesAsync();
    }
}
