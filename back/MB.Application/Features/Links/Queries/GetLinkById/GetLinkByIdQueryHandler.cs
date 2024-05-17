using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Links.Queries.GetLinkById;

public class GetLinkByIdQueryHandler : IRequestHandler<GetLinkByIdQuery, GetLinkByIdQueryResponse>
{
    private readonly IMapper _mapper;
    private IBaseRepository<Link> _linkRepository;

    public GetLinkByIdQueryHandler(IMapper mapper, IBaseRepository<Link> linkRepository)
    {
        _mapper = mapper;
        _linkRepository = linkRepository;
    }

    public async Task<GetLinkByIdQueryResponse> Handle(GetLinkByIdQuery request, CancellationToken cancellationToken)
    {
        var link = await _linkRepository.GetByBusinessIdAsync(request.LinkId);

        if (link == null)
        {
            return new GetLinkByIdQueryResponse { Success = false, Message = "Link wasn't found :(" };
        }

        var linkVm = _mapper.Map<GetLinkByIdVm>(link);

        return new GetLinkByIdQueryResponse
        {
            Success = true,
            Message = "Link was found :)",
            Link = linkVm
        };
    }
}