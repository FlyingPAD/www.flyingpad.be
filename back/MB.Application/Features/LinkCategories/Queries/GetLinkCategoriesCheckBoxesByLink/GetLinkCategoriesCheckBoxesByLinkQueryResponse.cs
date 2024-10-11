using MB.Application.Models;

namespace MB.Application.Features.LinkCategories.Queries.GetLinkCategoriesCheckBoxesByLink
{
    public class GetLinkCategoriesCheckBoxesByLinkQueryResponse : BaseResponse
    {
        public GetLinkCategoriesCheckBoxesByLinkQueryDto[] LinkCategories { get; set; } = [];
    }
}