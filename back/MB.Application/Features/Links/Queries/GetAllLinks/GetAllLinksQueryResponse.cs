using MB.Application.Models;

namespace MB.Application.Features.Links.Queries.GetAllLinks;

public class GetAllLinksQueryResponse : BaseResponse
{
    public List<GetAllLinksQueryDto> Links { get; set; } = [];
}