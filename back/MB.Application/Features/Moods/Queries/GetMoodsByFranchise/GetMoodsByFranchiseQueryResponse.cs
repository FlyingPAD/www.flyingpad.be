namespace MB.Application.Features.Moods.Queries.GetMoodsByFranchise;

public class GetMoodsByFranchiseQueryResponse : BaseResponse
{
    public List<MoodLightDto> Moods { get; set; } = [];
}