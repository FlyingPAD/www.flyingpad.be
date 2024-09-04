using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.LinkCategories.Queries.CountLinkCategories;

public class CountLinkCategoriesQueryHandler : IRequestHandler<CountLinkCategoriesQuery, CountLinkCategoriesQueryResponse>
{
    private readonly IBaseRepository<LinkCategory> _linkCategoryRepository;

    public CountLinkCategoriesQueryHandler(IBaseRepository<LinkCategory> linkCategoryRepository)
    {
        _linkCategoryRepository = linkCategoryRepository;
    }

    public async Task<CountLinkCategoriesQueryResponse> Handle(CountLinkCategoriesQuery request, CancellationToken cancellationToken)
    {
        var linkCategoriesCount = await _linkCategoryRepository.CountAsync();

        return new CountLinkCategoriesQueryResponse
        {
            Success = true,
            Message = $"Total Link Categories : {linkCategoriesCount}",
            LinkCategoriesCount = linkCategoriesCount
        };
    }
}