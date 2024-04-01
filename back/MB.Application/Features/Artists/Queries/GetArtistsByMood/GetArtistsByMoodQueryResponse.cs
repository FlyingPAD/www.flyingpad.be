using MB.Application.Responses;

namespace MB.Application.Features.Artists.Queries.GetArtistsByMood
{
    public class GetArtistsByMoodQueryResponse : BaseResponse
    {
        public List<GetArtistsByMoodQueryVm> ArtistsByMood { get; set; } = [];
    }
}