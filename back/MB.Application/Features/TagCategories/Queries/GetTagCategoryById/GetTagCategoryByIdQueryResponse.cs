using MB.Application.Models;

namespace MB.Application.Features.TagCategories.Queries.GetTagCategoryById;

public class GetTagCategoryByIdQueryResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    /// 
    public GetTagCategoryByIdVm TagCategory { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public GetTagCategoryByIdQueryResponse() : base()
    {

    }
}
