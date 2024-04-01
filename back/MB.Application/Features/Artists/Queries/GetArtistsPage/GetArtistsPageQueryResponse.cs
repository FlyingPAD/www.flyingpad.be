using MB.Application.Responses;

namespace MB.Application.Features.Artists.Queries.GetArtistsPage
{
    public class GetArtistsPageQueryResponse : BaseResponse
    {
        public List<GetArtistsPageVm> ArtistsPage { get; set; } = [];

        public int TotalItems { get; set; } = 0;
        public int ItemPosition { get; set; } = 0;
        public Guid? PreviousId { get; set; } = null;
        public Guid? NextId { get; set; } = null;

        public GetArtistsPageQueryResponse() : base()
        {

        }
    }
}