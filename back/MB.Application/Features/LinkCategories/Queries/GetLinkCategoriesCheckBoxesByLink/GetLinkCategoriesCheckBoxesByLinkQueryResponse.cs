using MB.Application.Responses;

namespace MB.Application.Features.LinkCategories.Queries.GetLinkCategoriesCheckBoxesByLink
{
    public class GetLinkCategoriesCheckBoxesByLinkQueryResponse : BaseResponse
    {
        public GetLinkCategoriesCheckBoxesByLinkQueryDto[] LinkCategoriesCheckBoxes { get; set; } = [];
    }
}
