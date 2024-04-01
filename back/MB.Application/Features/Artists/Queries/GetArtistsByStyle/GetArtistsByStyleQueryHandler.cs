using AutoMapper;
using MB.Application.Contracts.Persistence;
using MediatR;

namespace MB.Application.Features.Artists.Queries.GetArtistsByStyle
{
    public class GetArtistsByStyleQueryHandler(IMapper mapper, IArtistRepository artistRepository, IStyleRepository styleRepository) : IRequestHandler<GetArtistsByStyleQuery, GetArtistsByStyleQueryResponse>
    {
        private readonly IMapper _mapper = mapper;
        private readonly IArtistRepository _artistRepository = artistRepository;
        private readonly IStyleRepository _styleRepository = styleRepository;

        public async Task<GetArtistsByStyleQueryResponse> Handle(GetArtistsByStyleQuery request, CancellationToken cancellationToken)
        {
            int? styleId = await _styleRepository.GetPrimaryIdByBusinessIdAsync(request.BusinessId);

            var artists = await _artistRepository.GetArtistsByStyle(styleId);

            var response = new GetArtistsByStyleQueryResponse
            {
                Success = true,
                Message = "Artists",
                Artists = _mapper.Map<List<GetArtistsByStyleVm>>(artists)
            };

            return response;
        }
    }
}