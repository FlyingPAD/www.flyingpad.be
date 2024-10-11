using MB.Application.Models;

namespace MB.Application.Features.TagCategories.Queries.CountTagCategories;

public class CountTagCategoriesQueryResponse : BaseResponse
{
    public int TotalTagCategories { get; set; }
}