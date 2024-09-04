using AutoMapper;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Links.Queries.GetLinkById;

public class GetLinkByIdQueryHandler(IMapper mapper, IBaseRepository<Link> linkRepository) : IRequestHandler<GetLinkByIdQuery, GetLinkByIdQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Link> _linkRepository = linkRepository;

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