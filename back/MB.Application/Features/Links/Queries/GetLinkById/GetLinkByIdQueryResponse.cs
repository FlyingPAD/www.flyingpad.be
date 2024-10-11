using MB.Application.Models;

namespace MB.Application.Features.Links.Queries.GetLinkById;

public class GetLinkByIdQueryResponse : BaseResponse
{
    public GetLinkByIdQueryDto Link { get; set; } = new();
}