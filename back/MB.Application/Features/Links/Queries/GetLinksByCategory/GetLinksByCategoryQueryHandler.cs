using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Links.Queries.GetLinksByCategory;

public class GetLinksByCategoryQueryHandler(ILinkRepository linkRepository, ILinkCategoryRepository linkCategoryRepository, IMapper mapper) : IRequestHandler<GetLinksByCategoryQuery, GetLinksByCategoryQueryResponse>
{
    private readonly ILinkRepository _linkRepository = linkRepository;
    private readonly ILinkCategoryRepository _linkCategoryRepository = linkCategoryRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<GetLinksByCategoryQueryResponse> Handle(GetLinksByCategoryQuery request, CancellationToken cancellationToken)
    {
        int linkCategoryId = await _linkCategoryRepository.GetPrimaryIdByBusinessIdAsync(request.LinkCategoryId)
            ?? throw new NotFoundException("Link category not found.");

        var links = await _linkRepository.GetLinksListByCategory(linkCategoryId);

        return new GetLinksByCategoryQueryResponse
        {
            Success = true,
            Message = "Links by category",
            Links = _mapper.Map<List<GetLinksByCategoryQueryDto>>(links)
        };
    }
}