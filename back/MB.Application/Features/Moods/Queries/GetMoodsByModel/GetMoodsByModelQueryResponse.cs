namespace MB.Application.Features.Moods.Queries.GetMoodsByModel;

public class GetMoodsByModelQueryResponse : BaseResponse
{
    public List<MoodLightDto> Moods { get; set; } = [];
}