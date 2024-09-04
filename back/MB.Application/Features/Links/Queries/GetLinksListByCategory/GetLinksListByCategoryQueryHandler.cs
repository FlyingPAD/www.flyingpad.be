using AutoMapper;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Links.Queries.GetLinksListByCategory;

public class GetLinksListByCategoryQueryHandler(ILinkRepository linkRepository, ILinkCategoryRepository linkCategoryRepository, IMapper mapper) : IRequestHandler<GetLinksListByCategoryQuery, GetLinksListByCategoryQueryResponse>
{
    private readonly ILinkRepository _linkRepository = linkRepository;
    private readonly ILinkCategoryRepository _linkCategoryRepository = linkCategoryRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<GetLinksListByCategoryQueryResponse> Handle(GetLinksListByCategoryQuery request, CancellationToken cancellationToken)
    {
        int? linkCategoryId = await _linkCategoryRepository.GetPrimaryIdByBusinessIdAsync(request.LinkCategoryId);

        var links = await _linkRepository.GetLinksListByCategory(linkCategoryId);

        var response = new GetLinksListByCategoryQueryResponse
        {
            Success = true,
            Message = "Links list by Category",
            Links = _mapper.Map<List<LinksListByCategoryVm>>(links)
        };

        return response;
    }

}