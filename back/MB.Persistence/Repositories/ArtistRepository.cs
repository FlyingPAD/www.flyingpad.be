using MB.Application.Features.Artists.Queries.GetArtistCheckBoxesByMood;
using MB.Application.Interfaces.Persistence;
using MB.Domain;
using MB.Domain.ArtistAggregate;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories;

public class ArtistRepository(Context context) : BaseRepository<Artist>(context), IArtistRepository
{
    public async Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds)
    {
        return await _context.Artists
                             .Where(artist => businessIds.Contains(artist.BusinessId))
                             .Select(artist => artist.EntityId)
                             .ToListAsync();
    }

    public async Task<IEnumerable<Artist>> GetArtistsByMood(int? moodId)
    {
        return await _context.Artists
            .Where(artist => artist.MoodArtists != null && artist.MoodArtists.Any(relation => relation.MoodId == moodId))
            .ToListAsync();
    }

    public async Task<IEnumerable<Artist>> GetArtistsByStyle(int styleId)
    {
        return await _context.Artists
            .Where(artist => artist.ArtistStyles != null && artist.ArtistStyles
            .Any(relation => relation.StyleId == styleId))
            .OrderBy(artist => artist.Name)
            .ToListAsync();
    }

    public async Task<PaginationCursor<Artist>> GetArtistsPage(int? styleId, int? startId, string abc, int pageSize)
    {
        IQueryable<Artist> query = _context.Artists;

        if (styleId.HasValue)
        {
            query = query.Where(artist => artist.ArtistStyles != null && artist.ArtistStyles.Any(style => style.StyleId == styleId));
        }

        if (!string.IsNullOrEmpty(abc))
        {
            query = query.Where(artist => EF.Functions.Like(artist.Name, $"%{abc}%"));
        }

        var orderedArtists = await query.OrderBy(artist => artist.Name).ToListAsync();

        int startIndex = 0;
        if (startId.HasValue)
        {
            var artistIndex = orderedArtists.FindIndex(a => a.EntityId == startId.Value);
            startIndex = artistIndex >= 0 ? artistIndex : 0;
        }

        var page = orderedArtists.Skip(startIndex).Take(pageSize).ToList();

        Guid? nextId = startIndex + pageSize < orderedArtists.Count ? orderedArtists[startIndex + pageSize].BusinessId : null;
        Guid? previousId = startIndex - pageSize >= 0 ? orderedArtists[Math.Max(0, startIndex - pageSize)].BusinessId : null;

        var response = new PaginationCursor<Artist>
        {
            Entities = page,
            TotalItems = orderedArtists.Count,
            ItemPosition = startIndex,
            NextId = nextId,
            PreviousId = previousId
        };

        return response;
    }

    public async Task<IEnumerable<GetArtistCheckBoxesByMoodQueryDto>> GetArtistsCheckBoxesByMood(int moodId)
    {
        var artists = await _context.Artists
                                   .Select(artist => new GetArtistCheckBoxesByMoodQueryDto
                                   {
                                       BusinessId = artist.BusinessId,
                                       Name = artist.Name,
                                       IsChecked = artist.MoodArtists != null && artist.MoodArtists.Any(ma => ma.MoodId == moodId)
                                   })
                                   .OrderBy(artist => artist.Name)
                                   .ToListAsync();

        return artists;
    }

    public async System.Threading.Tasks.Task DeleteArtistRelations(int artistId)
    {
        var artistStyles = await _context.RArtistStyle
                                         .Where(relation => relation.ArtistId == artistId)
                                         .ToListAsync();

        _context.RArtistStyle.RemoveRange(artistStyles);

        await _context.SaveChangesAsync();
    }

    public async Task<Artist?> GetArtistWithStylesAsync(int artistId)
    {
        return await _context.Artists
            .Include(artist => artist.ArtistStyles)
            .FirstOrDefaultAsync(artist => artist.EntityId == artistId);
    }

    public async System.Threading.Tasks.Task RemoveArtistStylesAsync(Artist artist)
    {
        _context.RArtistStyle.RemoveRange(artist.ArtistStyles ?? []);
        await _context.SaveChangesAsync();
    }

    public async System.Threading.Tasks.Task AddArtistStylesAsync(int artistId, IEnumerable<int> styleIds)
    {
        var relationsToAdd = styleIds.Select(styleId => new RelationArtistStyle
        {
            ArtistId = artistId,
            StyleId = styleId
        }).ToList();

        _context.RArtistStyle.AddRange(relationsToAdd);
        await _context.SaveChangesAsync();
    }
}