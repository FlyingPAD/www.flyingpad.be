using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Artists.Queries.CountArtists;

public class CountArtistsQueryHandler(IBaseRepository<Artist> artistRepository) : IRequestHandler<CountArtistsQuery, CountArtistsQueryResponse>
{
    private readonly IBaseRepository<Artist> _artistRepository = artistRepository;

    public async Task<CountArtistsQueryResponse> Handle(CountArtistsQuery request, CancellationToken cancellationToken)
    {
        return new CountArtistsQueryResponse
        {
            Success = true,
            Message = "Artists count completed.",
            TotalArtists = await _artistRepository.CountAsync()
        };
    }
}