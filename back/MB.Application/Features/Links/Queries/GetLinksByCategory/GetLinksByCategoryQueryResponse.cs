using MB.Application.Models;

namespace MB.Application.Features.Links.Queries.GetLinksByCategory;

public class GetLinksByCategoryQueryResponse : BaseResponse
{
    public List<GetLinksByCategoryQueryDto> Links { get; set; } = [];
}