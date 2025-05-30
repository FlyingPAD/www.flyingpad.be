using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence.Definitions;
using MediatR;

namespace MB.Application.Features.LinkCategories.Queries.GetLinkCategoriesCheckBoxesByLink
{
    public class GetLinkCategoriesCheckBoxesByLinkQueryHandler(IMapper mapper, ILinkRepository linkRepo, ILinkCategoryRepository linkCategoryRepo) : IRequestHandler<GetLinkCategoriesCheckBoxesByLinkQuery, GetLinkCategoriesCheckBoxesByLinkQueryResponse>
    {
        private readonly IMapper _mapper = mapper;
        private readonly ILinkRepository _linkRepo = linkRepo;
        private readonly ILinkCategoryRepository _linkCategoryRepo = linkCategoryRepo;

        public async Task<GetLinkCategoriesCheckBoxesByLinkQueryResponse> Handle(GetLinkCategoriesCheckBoxesByLinkQuery request, CancellationToken cancellationToken)
        {
            int linkId = await _linkRepo.GetEntityIdByBusinessIdAsync(request.LinkId, cancellationToken)
                ?? throw new NotFoundException("Link not found.");

            var categories = await _linkCategoryRepo.GetCheckBoxesByLink(linkId);

            return new GetLinkCategoriesCheckBoxesByLinkQueryResponse
            {
                Success = true,
                Message = "Link checkboxes loaded.",
                LinkCategories = _mapper.Map<GetLinkCategoriesCheckBoxesByLinkQueryDto[]>(categories)
            };
        }
    }
}