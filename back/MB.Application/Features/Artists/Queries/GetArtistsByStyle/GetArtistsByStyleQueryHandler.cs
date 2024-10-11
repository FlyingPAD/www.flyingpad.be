using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Artists.Queries.GetArtistsByStyle;

public class GetArtistsByStyleQueryHandler(IMapper mapper, IArtistRepository artistRepository, IStyleRepository styleRepository) : IRequestHandler<GetArtistsByStyleQuery, GetArtistsByStyleQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IArtistRepository _artistRepository = artistRepository;
    private readonly IStyleRepository _styleRepository = styleRepository;

    public async Task<GetArtistsByStyleQueryResponse> Handle(GetArtistsByStyleQuery request, CancellationToken cancellationToken)
    {
        int styleId = await _styleRepository.GetPrimaryIdByBusinessIdAsync(request.StyleId)
            ?? throw new NotFoundException("Style not found.");

        var artists = await _artistRepository.GetArtistsByStyle(styleId);

        return new GetArtistsByStyleQueryResponse
        {
            Success = true,
            Message = "Artists by style.",
            Artists = _mapper.Map<List<GetArtistsByStyleQueryDto>>(artists)
        };
    }
}