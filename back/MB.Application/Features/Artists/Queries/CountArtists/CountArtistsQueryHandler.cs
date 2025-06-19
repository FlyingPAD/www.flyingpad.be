using MB.Application.Interfaces.Persistence.Read;
using MediatR;

namespace MB.Application.Features.Artists.Queries.CountArtists;

public class CountArtistsQueryHandler(IReadArtistRepository artistRepository) : IRequestHandler<CountArtistsQuery, CountArtistsQueryResponse>
{
    private readonly IReadArtistRepository _artistRepository = artistRepository;

    public async Task<CountArtistsQueryResponse> Handle(CountArtistsQuery request, CancellationToken cancellationToken)
    {
        return new CountArtistsQueryResponse
        {
            Success = true,
            Message = "Artists count completed.",
            TotalArtists = await _artistRepository.CountAsync(cancellationToken)
        };
    }
}