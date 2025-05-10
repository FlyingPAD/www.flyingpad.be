using MB.Application.Models;

namespace MB.Application.Features.Moods.Queries.GetMoodById;

public class GetMoodByIdQueryResponse : BaseResponse
{
    public GetMoodByIdQueryDto Mood { get; set; } = new();
}