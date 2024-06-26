using AutoMapper;
using MB.Application.Contracts.Persistence;
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
            int? linkEntityId = await _linkRepo.GetPrimaryIdByBusinessIdAsync(request.LinkId);

            if (!linkEntityId.HasValue)
            {
                return new GetLinkCategoriesCheckBoxesByLinkQueryResponse
                {
                    Success = false,
                    Message = "Link was not found."
                };
            }

            var categories = await _linkCategoryRepo.GetCheckBoxesByLink((int)linkEntityId);

            var response = new GetLinkCategoriesCheckBoxesByLinkQueryResponse
            {
                Success = true,
                Message = "Categories retrieved successfully",
                LinkCategories = _mapper.Map<GetLinkCategoriesCheckBoxesByLinkQueryDto[]>(categories)
            };

            return response;
        }
    }
}