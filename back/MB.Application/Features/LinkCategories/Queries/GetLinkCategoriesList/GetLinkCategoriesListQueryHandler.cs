using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.LinkCategories.Queries.GetLinkCategoriesList;

public class GetLinkCategoriesListQueryHandler : IRequestHandler<GetLinkCategoriesListQuery, GetLinkCategoriesListQueryResponse>
{
    private readonly IBaseRepository<LinkCategory> _linkCategoryRepository;
    private readonly IMapper _mapper;

    public GetLinkCategoriesListQueryHandler(IBaseRepository<LinkCategory> linkCategoryRepository, IMapper mapper)
    {
        _linkCategoryRepository = linkCategoryRepository;
        _mapper = mapper;
    }

    public async Task<GetLinkCategoriesListQueryResponse> Handle(GetLinkCategoriesListQuery request, CancellationToken cancellationToken)
    {
        var linkCategories = await _linkCategoryRepository.GetAllAsync(category => category.Name, true);

        var response = new GetLinkCategoriesListQueryResponse
        {
            Success = true,
            Message = "Success !",
            LinkCategories = _mapper.Map<List<LinkCategoryListVm>>(linkCategories)
        };

        return response;
    }
}
