using MB.Application.Contracts.Persistence;
using MB.Application.Features.Artists.Queries.GetArtistCheckBoxesByMood;
using MB.Domain.Common;
using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories;

public class ArtistRepository(Context context) : BaseRepository<Artist>(context), IArtistRepository
{
    /// <summary>
    /// Retrieves primary IDs by business IDs.
    /// </summary>
    public async Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds)
    {
        return await _context.Artists
                             .Where(artist => businessIds.Contains(artist.BusinessId))
                             .Select(artist => artist.EntityId)
                             .ToListAsync();
    }

    /// <summary>
    /// Fetches artists associated with a specific mood.
    /// </summary>
    public async Task<IEnumerable<Artist>> GetArtistsByMood(int? moodId)
    {
        return await _context.Artists
            .Where(artist => artist.MoodArtists != null && artist.MoodArtists.Any(relation => relation.MoodId == moodId))
            .ToListAsync();
    }

    /// <summary>
    /// Fetches artists associated with a specific style.
    /// </summary>
    public async Task<IEnumerable<Artist>> GetArtistsByStyle(int? styleId)
    {
        return await _context.Artists
            .Where(artist => artist.ArtistStyles != null && artist.ArtistStyles.Any(relation => relation.StyleId == styleId))
            .ToListAsync();
    }

    /// <summary>
    /// Retrieves a paginated list of artists.
    /// </summary>
    public async Task<PaginationCursor<Artist>> GetArtistsPage(int? styleId, int? startId, string abc, int pageSize)
    {
        IQueryable<Artist> query = _context.Artists;

        // Filters
        if (styleId.HasValue)
        {
            query = query.Where(artist => artist.ArtistStyles != null && artist.ArtistStyles.Any(style => style.StyleId == styleId));
        }

        if (!string.IsNullOrEmpty(abc))
        {
            query = query.Where(artist => EF.Functions.Like(artist.Name, $"%{abc}%"));
        }

        // Order & fetch artists full list
        var orderedArtists = await query.OrderBy(artist => artist.Name).ToListAsync();

        // Find start element index based on EntityId ( startId )
        int startIndex = 0;
        if (startId.HasValue)
        {
            var artistIndex = orderedArtists.FindIndex(a => a.EntityId == startId.Value);
            startIndex = artistIndex >= 0 ? artistIndex : 0;
        }

        // Pagination
        var page = orderedArtists.Skip(startIndex).Take(pageSize).ToList();

        // Build response with NextId & PreviousId
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

    /// <summary>
    /// Retrieves artist checkboxes by mood.
    /// </summary>
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

    /// <summary>
    /// Deletes all styles associated with a specific artist.
    /// </summary>
    public async System.Threading.Tasks.Task DeleteStyles(int artistId)
    {
        var artistStyles = await _context.RArtistStyle
                                         .Where(relation => relation.ArtistId == artistId)
                                         .ToListAsync();

        _context.RArtistStyle.RemoveRange(artistStyles);

        await _context.SaveChangesAsync();
    }
}