using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Artists.Queries.CountArtists
{
    public class CountArtistsQueryHandler : IRequestHandler<CountArtistsQuery, CountArtistsQueryResponse>
    {
        private readonly IBaseRepository<Artist> _artistRepository;

        public CountArtistsQueryHandler(IBaseRepository<Artist> artistRepository)
        {
            _artistRepository = artistRepository;
        }

        public async Task<CountArtistsQueryResponse> Handle(CountArtistsQuery request, CancellationToken cancellationToken)
        {
            var artistsCount = await _artistRepository.CountAsync();

            return new CountArtistsQueryResponse
            {
                Success = true,
                Message = $"Total Artists : {artistsCount}",
                ArtistsCount = artistsCount
            };
        }
    }
}