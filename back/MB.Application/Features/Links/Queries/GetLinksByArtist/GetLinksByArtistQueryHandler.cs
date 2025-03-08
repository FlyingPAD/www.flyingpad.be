using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Domain.ArtistAggregate;
using MediatR;

namespace MB.Application.Features.Links.Queries.GetLinksByArtist
{
    public class GetLinksByArtistQueryHandler(ILinkRepository linkRepository, IBaseRepository<Artist> artistRepository, IMapper mapper) : IRequestHandler<GetLinksByArtistQuery, GetLinksByArtistQueryResponse>
    {
        private readonly ILinkRepository _linkRepository = linkRepository;
        private readonly IBaseRepository<Artist> _artistRepository = artistRepository;
        private readonly IMapper _mapper = mapper;

        public async Task<GetLinksByArtistQueryResponse> Handle(GetLinksByArtistQuery request, CancellationToken cancellationToken)
        {
            int artistId = await _artistRepository.GetPrimaryIdByBusinessIdAsync(request.ArtistId)
                ?? throw new NotFoundException("Artist not found.");

            var links = await _linkRepository.GetLinksByArtist(artistId);

            return new GetLinksByArtistQueryResponse
            {
                Success = true,
                Message = "Related Links.",
                Links = _mapper.Map<List<GetLinksByArtistQueryDto>>(links)
            };
        }
    }
}