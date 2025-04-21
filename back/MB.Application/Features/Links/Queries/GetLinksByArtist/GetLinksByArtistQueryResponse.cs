namespace MB.Application.Features.Links.Queries.GetLinksByArtist
{
    public class GetLinksByArtistQueryResponse : BaseResponse
    {
        public IEnumerable<GetLinksByArtistQueryDto> Links { get; set; } = [];
    }
}