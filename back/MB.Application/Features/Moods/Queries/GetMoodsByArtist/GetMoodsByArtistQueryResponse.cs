namespace MB.Application.Features.Moods.Queries.GetMoodsByArtist;

public class GetMoodsByArtistQueryResponse : BaseResponse
{
    public List<GetMoodsByArtistQueryVm> Moods { get; set; } = [];
}
