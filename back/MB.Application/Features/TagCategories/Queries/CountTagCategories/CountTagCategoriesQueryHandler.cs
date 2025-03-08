using MB.Application.Interfaces.Persistence;
using MB.Domain.TagCategoryAggregate;
using MediatR;

namespace MB.Application.Features.TagCategories.Queries.CountTagCategories;

public class CountTagCategoriesQueryHandler(IBaseRepository<TagCategory> tagCategoryRepository) : IRequestHandler<CountTagCategoriesQuery, CountTagCategoriesQueryResponse>
{
    private readonly IBaseRepository<TagCategory> _tagCategoryRepository = tagCategoryRepository;

    public async Task<CountTagCategoriesQueryResponse> Handle(CountTagCategoriesQuery request, CancellationToken cancellationToken)
    {
        return new CountTagCategoriesQueryResponse
        {
            Success = true,
            Message = "Tag categories count completed.",
            TotalTagCategories = await _tagCategoryRepository.CountAsync()
        };
    }
}