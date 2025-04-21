namespace MB.Application.Features.TagCategories.Queries.GetTagCategoryById;

public class GetTagCategoryByIdQueryResponse : BaseResponse
{
    public GetTagCategoryByIdQueryDto TagCategory { get; set; } = new();
}