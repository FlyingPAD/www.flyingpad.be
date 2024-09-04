using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.TagCategories.Queries.CountTagCategories;

public class CountTagCategoriesQueryHandler : IRequestHandler<CountTagCategoriesQuery, CountTagCategoriesQueryResponse>
{
    private readonly IBaseRepository<TagCategory> _tagCategoryRepository;

    public CountTagCategoriesQueryHandler(IBaseRepository<TagCategory> tagCategoryRepository)
    {
        _tagCategoryRepository = tagCategoryRepository;
    }

    public async Task<CountTagCategoriesQueryResponse> Handle(CountTagCategoriesQuery request, CancellationToken cancellationToken)
    {
        var tagCategoriesCount = await _tagCategoryRepository.CountAsync();

        return new CountTagCategoriesQueryResponse
        {
            Success = true,
            Message = $"Total Tag Categories : {tagCategoriesCount}",
            TagCategoriesCount = tagCategoriesCount
        };
    }
}
