using MB.Application.Interfaces.Infrastructure;
using MB.Application.Interfaces.Persistence;
using MB.Domain.ArtistAggregate;

namespace MB.Persistence.Services;

public class EmailDataService(IArtistRepository artistRepository) : IEmailDataService
{
    private readonly IArtistRepository _artistRepository = artistRepository;

    public async Task<IEnumerable<Artist>> GetArtistsAsync()
    {
        return await _artistRepository.GetAllAsync();
    }

    public async Task<int> CountArtistsAsync()
    {
        return await _artistRepository.CountAsync();
    }
}