using MB.Application.Models;

namespace MB.Application.Features.LinkCategories.Queries.CountLinkCategories;

public class CountLinkCategoriesQueryResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public int LinkCategoriesCount { get; set; }

    public CountLinkCategoriesQueryResponse() : base ()
    {

    }
}
