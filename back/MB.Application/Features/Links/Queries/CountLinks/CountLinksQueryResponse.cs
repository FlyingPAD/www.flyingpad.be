using MB.Application.Models;

namespace MB.Application.Features.Links.Queries.CountLinks;

public class CountLinksQueryResponse : BaseResponse
{
    public int TotalLinks { get; set; }
}