using MB.Application.Models;

namespace MB.Application.Features.LinkCategories.Queries.CountLinkCategories;

public class CountLinkCategoriesQueryResponse : BaseResponse
{
    public int TotalLinkCategories { get; set; }
}