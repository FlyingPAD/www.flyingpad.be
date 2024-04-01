using AutoMapper;
using MB.Application.Contracts.Persistence;
using MediatR;

namespace MB.Application.Features.Links.Queries.GetLinksListByCategory
{
    public class GetLinksListByCategoryQueryHandler : IRequestHandler<GetLinksListByCategoryQuery, GetLinksListByCategoryQueryResponse>
    {
        private readonly ILinkRepository _linkRepository;
        private readonly ILinkCategoryRepository _linkCategoryRepository;
        private readonly IMapper _mapper;

        public GetLinksListByCategoryQueryHandler(ILinkRepository linkRepository, ILinkCategoryRepository linkCategoryRepository,IMapper mapper)
        {
            _linkRepository = linkRepository;
            _linkCategoryRepository = linkCategoryRepository;
            _mapper = mapper;
        }

        public async Task<GetLinksListByCategoryQueryResponse> Handle(GetLinksListByCategoryQuery request, CancellationToken cancellationToken)
        {
            int? linkCategoryId = await _linkCategoryRepository.GetPrimaryIdByBusinessIdAsync(request.LinkCategoryId);

            var links = await _linkRepository.GetLinksListByCategory(linkCategoryId);

            var response = new GetLinksListByCategoryQueryResponse
            {
                Success = true,
                Message = "Links list by Category",
                LinksListByCategory = _mapper.Map<List<LinksListByCategoryVm>>(links)
            };

            return response;
        }

    }
}