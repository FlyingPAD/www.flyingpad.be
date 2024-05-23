using MB.Application.Responses;

namespace MB.Application.Features.TagCategories.Queries.GetTagCategoriesList;

public class GetTagCategoriesListQueryResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    /// 
    public List<TagCategoryListVm> TagCategories { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public GetTagCategoriesListQueryResponse() : base()
    {

    }
}
