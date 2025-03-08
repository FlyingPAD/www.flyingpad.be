using MB.Application.Interfaces.Persistence;
using MB.Domain.LinkCategoryAggregate;
using MediatR;

namespace MB.Application.Features.LinkCategories.Queries.CountLinkCategories;

public class CountLinkCategoriesQueryHandler(IBaseRepository<LinkCategory> linkCategoryRepository) : IRequestHandler<CountLinkCategoriesQuery, CountLinkCategoriesQueryResponse>
{
    private readonly IBaseRepository<LinkCategory> _linkCategoryRepository = linkCategoryRepository;

    public async Task<CountLinkCategoriesQueryResponse> Handle(CountLinkCategoriesQuery request, CancellationToken cancellationToken)
    {
        return new CountLinkCategoriesQueryResponse
        {
            Success = true,
            Message = "Link categories count completed.",
            TotalLinkCategories = await _linkCategoryRepository.CountAsync()
        };
    }
}