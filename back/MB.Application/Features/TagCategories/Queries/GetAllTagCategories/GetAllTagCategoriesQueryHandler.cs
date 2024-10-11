using AutoMapper;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.TagCategories.Queries.GetAllTagCategories;

public class GetAllTagCategoriesQueryHandler(IBaseRepository<TagCategory> tagCategoryRepository, IMapper mapper) : IRequestHandler<GetAllTagCategoriesQuery, GetAllTagCategoriesQueryResponse>
{
    private readonly IBaseRepository<TagCategory> _tagCategoryRepository = tagCategoryRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<GetAllTagCategoriesQueryResponse> Handle(GetAllTagCategoriesQuery request, CancellationToken cancellationToken)
    {
        var tagCategories = await _tagCategoryRepository.GetAllAsync(tagCategory => tagCategory.Name);

        return new GetAllTagCategoriesQueryResponse
        {
            Success = true,
            Message = "All tag categories.",
            TagCategories = _mapper.Map<List<GetAllTagCategoriesQueryDto>>(tagCategories)
        };
    }
}