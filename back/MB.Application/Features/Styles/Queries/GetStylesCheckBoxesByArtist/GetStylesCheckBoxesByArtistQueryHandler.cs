using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Styles.Queries.GetStylesCheckBoxesByArtist;

public class GetStylesCheckBoxesByArtistQueryHandler(IMapper mapper, IArtistRepository artistRepository, IStyleRepository styleRepository) : IRequestHandler<GetStylesCheckBoxesByArtistQuery, GetStylesCheckBoxesByArtistQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IArtistRepository _artistRepository = artistRepository;
    private readonly IStyleRepository _styleRepository = styleRepository;

    public async Task<GetStylesCheckBoxesByArtistQueryResponse> Handle(GetStylesCheckBoxesByArtistQuery request, CancellationToken cancellationToken)
    {
        var artistId = await _artistRepository.GetPrimaryIdByBusinessIdAsync(request.ArtistId)
            ?? throw new NotFoundException("Artist not found.");
        
        var styles = await _styleRepository.GetCheckBoxesByArtist(artistId);

        return new GetStylesCheckBoxesByArtistQueryResponse
        {
            Success = true,
            Message = "Styles checkboxes by artist.",
            Styles = _mapper.Map<List<GetStylesCheckBoxesByArtistQueryDto>>(styles)
        };
    }
}