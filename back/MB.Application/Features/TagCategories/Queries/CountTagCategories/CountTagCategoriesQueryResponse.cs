using MB.Application.Responses;

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
