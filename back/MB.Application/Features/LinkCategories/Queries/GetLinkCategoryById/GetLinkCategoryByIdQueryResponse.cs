using MB.Application.Models;

namespace MB.Application.Features.LinkCategories.Queries.GetLinkCategoryById;

public class GetLinkCategoryByIdQueryResponse : BaseResponse
{
    public GetLinkCategoryByIdQueryDto LinkCategory { get; set; } = new();
}