﻿using MB.Application.Features.Artists.Queries.GetArtistCheckBoxesByMood;
using MB.Domain;
using MB.Domain.ArtistAggregate;

namespace MB.Application.Interfaces.Persistence;

public interface IArtistRepository : IBaseRepository<Artist>
{
    Task<IEnumerable<Artist>> GetArtistsByMood(int? moodId);
    Task<IEnumerable<Artist>> GetArtistsByStyle(int styleId);
    Task<PaginationCursor<Artist>> GetArtistsPage(int? styleId, int? startId, string abc, int pageSize);
    Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> artistIds);
    Task<IEnumerable<GetArtistCheckBoxesByMoodQueryDto>> GetArtistsCheckBoxesByMood(int moodId);
    System.Threading.Tasks.Task DeleteArtistRelations(int artistId);
    System.Threading.Tasks.Task AddArtistStylesAsync(int artistId, IEnumerable<int> styleIds);
    System.Threading.Tasks.Task RemoveArtistStylesAsync(Artist artist);
    Task<Artist?> GetArtistWithStylesAsync(int artistId);
}