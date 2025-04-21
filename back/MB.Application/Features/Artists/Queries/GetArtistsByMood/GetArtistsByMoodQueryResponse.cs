namespace MB.Application.Features.Artists.Queries.GetArtistsByMood;

public class GetArtistsByMoodQueryResponse : BaseResponse
{
    public List<GetArtistsByMoodQueryDto> ArtistsByMood { get; set; } = [];
}