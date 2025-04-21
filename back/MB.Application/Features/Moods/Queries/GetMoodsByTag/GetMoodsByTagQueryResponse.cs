namespace MB.Application.Features.Moods.Queries.GetMoodsByTag;

public class GetMoodsByTagQueryResponse : BaseResponse
{
    public List<MoodLightDto> Moods { get; set; } = [];
}