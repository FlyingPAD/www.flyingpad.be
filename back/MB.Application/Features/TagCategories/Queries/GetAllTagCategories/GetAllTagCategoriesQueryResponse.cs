using MB.Application.Models;

namespace MB.Application.Features.TagCategories.Queries.GetAllTagCategories;

public class GetAllTagCategoriesQueryResponse : BaseResponse
{
    public List<GetAllTagCategoriesQueryDto> TagCategories { get; set; } = [];
}