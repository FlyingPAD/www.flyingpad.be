using MB.Application.Models;

namespace MB.Application.Features.TagCategories.Queries.CountTagCategories;

public class CountTagCategoriesQueryResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public int TagCategoriesCount { get; set; }

    public CountTagCategoriesQueryResponse() : base ()
    {

    }
}
