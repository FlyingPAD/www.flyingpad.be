using MB.Application.Models;

namespace MB.Application.Features.Moods.Queries.GetMoodsByArtist;

public class GetMoodsByArtistQueryResponse : BaseResponse
{
    public List<GetMoodsByArtistQueryDto> Moods { get; set; } = [];
}