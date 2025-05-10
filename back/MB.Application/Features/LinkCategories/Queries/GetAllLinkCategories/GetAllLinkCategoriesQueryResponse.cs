using MB.Application.Models;

namespace MB.Application.Features.LinkCategories.Queries.GetAllLinkCategories;

public class GetAllLinkCategoriesQueryResponse : BaseResponse
{
    public List<GetAllLinkCategoriesQueryDto> LinkCategories { get; set; } = [];
}