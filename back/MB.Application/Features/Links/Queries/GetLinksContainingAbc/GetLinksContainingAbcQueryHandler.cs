using AutoMapper;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Links.Queries.GetLinksContainingAbc;

public class GetLinksContainingAbcQueryHandler : IRequestHandler<GetLinksContainingAbcQuery, GetLinksContainingAbcQueryResponse>
{
    public readonly IMapper _mapper;
    public readonly ILinkRepository _linkRepository;

    public GetLinksContainingAbcQueryHandler(IMapper mapper, ILinkRepository linkRepository)
    {
        _mapper = mapper;
        _linkRepository = linkRepository;
    }

    public async Task<GetLinksContainingAbcQueryResponse> Handle(GetLinksContainingAbcQuery request, CancellationToken cancellationToken)
    {
        var linksContainingAbc = await _linkRepository.GetLinksContainingAbc(request.Abc);

        var response = new GetLinksContainingAbcQueryResponse 
        { 
            Success = true,
            Message = $"Links Containing { request.Abc }",
            LinksContainingAbc = _mapper.Map<List<LinksContainingAbcVm>>(linksContainingAbc)
        };

        return response;
    }
}
