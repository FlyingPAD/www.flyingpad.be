using AutoMapper;
using FluentValidation;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Artists.Queries.GetArtistsPage;

public class GetArtistsPageQueryHandler(IMapper mapper, IArtistRepository artistRepository, IStyleRepository styleRepository, IValidator<GetArtistsPageQuery> validator) : IRequestHandler<GetArtistsPageQuery, GetArtistsPageQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IArtistRepository _artistRepository = artistRepository;
    private readonly IStyleRepository _styleRepository = styleRepository;
    private readonly IValidator<GetArtistsPageQuery> _validator = validator;

    public async Task<GetArtistsPageQueryResponse> Handle(GetArtistsPageQuery request, CancellationToken cancellationToken)
    {
        int? styleId = await _styleRepository.GetPrimaryIdByBusinessIdAsync(request.StyleId);
        int? startId = await _artistRepository.GetPrimaryIdByBusinessIdAsync(request.StartId);

        var artists = styleId.HasValue
            ? await _artistRepository.GetArtistsPage(styleId, startId, request.Abc, request.PageSize)
            : await _artistRepository.GetArtistsPage(null, startId, request.Abc, request.PageSize);

        var response = new GetArtistsPageQueryResponse
        {
            Success = true,
            Message = "Get Page of Artists",
            ArtistsPage = _mapper.Map<List<GetArtistsPageVm>>(artists.Entities),
            TotalItems = artists.TotalItems,
            ItemPosition = artists.ItemPosition,
            PreviousId = artists.PreviousId,
            NextId = artists.NextId
        };

        return response;
    }
}