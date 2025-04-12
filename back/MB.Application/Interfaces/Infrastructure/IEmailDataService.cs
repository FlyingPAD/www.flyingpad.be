using MB.Domain.ArtistAggregate;

namespace MB.Application.Interfaces.Infrastructure;

public interface IEmailDataService
{
    Task<IEnumerable<Artist>> GetArtistsAsync();
    Task<int> CountArtistsAsync();
}