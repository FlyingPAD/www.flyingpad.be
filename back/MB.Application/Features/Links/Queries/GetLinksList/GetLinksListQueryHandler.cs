using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MB.Application.Features.Links.Queries.GetLinksList;

public class GetLinksListQueryHandler(IBaseRepository<Link> linkRepository, IMapper mapper) : IRequestHandler<GetLinksListQuery, GetLinksListQueryResponse>
{
    private readonly IBaseRepository<Link> _linkRepository = linkRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<GetLinksListQueryResponse> Handle(GetLinksListQuery request, CancellationToken cancellationToken)
    {
        var linksQueryable = await _linkRepository.GetAllAsync(l => l.Name, true);

        var linksList = await linksQueryable.ToListAsync(cancellationToken);

        var response = new GetLinksListQueryResponse
        {
            Success = true,
            Message = "Here are the Links!",
            LinksList = _mapper.Map<List<LinkListVm>>(linksList)
        };

        return response;
    }
}