namespace MB.Application.Features.Artists.Queries.GetArtistCheckBoxesByMood;

public class GetArtistCheckBoxesByMoodQueryResponse : BaseResponse
{
    public IEnumerable<GetArtistCheckBoxesByMoodQueryDto> Artists { get; set; } = [];
}
