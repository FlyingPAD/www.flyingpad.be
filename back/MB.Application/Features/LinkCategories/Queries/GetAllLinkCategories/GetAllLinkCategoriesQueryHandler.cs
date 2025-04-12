using AutoMapper;
using MB.Application.Interfaces.Persistence;
using MB.Domain.LinkCategoryAggregate;
using MediatR;

namespace MB.Application.Features.LinkCategories.Queries.GetAllLinkCategories;

public class GetAllLinkCategoriesQueryHandler(IBaseRepository<LinkCategory> linkCategoryRepository, IMapper mapper) : IRequestHandler<GetAllLinkCategoriesQuery, GetAllLinkCategoriesQueryResponse>
{
    private readonly IBaseRepository<LinkCategory> _linkCategoryRepository = linkCategoryRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<GetAllLinkCategoriesQueryResponse> Handle(GetAllLinkCategoriesQuery request, CancellationToken cancellationToken)
    {
        var linkCategories = await _linkCategoryRepository.GetAllAsync(category => category.Name);

        return new GetAllLinkCategoriesQueryResponse
        {
            Success = true,
            Message = "Link categories",
            LinkCategories = _mapper.Map<List<GetAllLinkCategoriesQueryDto>>(linkCategories)
        };
    }
}