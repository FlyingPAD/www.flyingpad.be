using MB.Application.Features.Moods.Queries.GetRandomMood;

namespace MB.Application.Features.Moods.Queries;

public class GetRandomMoodQueryResponse : BaseResponse
{
    public GetRandomMoodQueryDto Mood { get; set; } = new();
}