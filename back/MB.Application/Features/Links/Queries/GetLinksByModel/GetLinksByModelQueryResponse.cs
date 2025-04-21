namespace MB.Application.Features.Links.Queries.GetLinksByModel
{
    public class GetLinksByModelQueryResponse : BaseResponse
    {
        public IEnumerable<GetLinksByModelQueryDto> Links { get; set; } = [];
    }
}