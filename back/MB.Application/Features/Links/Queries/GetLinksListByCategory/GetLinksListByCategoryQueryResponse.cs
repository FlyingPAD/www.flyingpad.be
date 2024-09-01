using MB.Application.Models;

namespace MB.Application.Features.Links.Queries.GetLinksListByCategory;

public class GetLinksListByCategoryQueryResponse : BaseResponse
{
    public List<LinksListByCategoryVm> Links { get; set; } = [];
}
