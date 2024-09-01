using MB.Application.Models;

namespace MB.Application.Features.Links.Queries.GetLinksList;

public class GetLinksListQueryResponse : BaseResponse
{
    public List<LinkListVm> Links { get; set; } = [];
}
