using MB.Application.Features.Moods.Queries.GetRandomMood;
using MB.Application.Models;

namespace MB.Application.Features.Moods.Queries;

public class GetRandomMoodQueryResponse : BaseResponse
{
    public GetRandomMoodQueryDto Mood { get; set; } = new();
}