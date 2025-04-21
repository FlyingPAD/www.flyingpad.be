namespace MB.Application.Features.Models.Queries.GetModelsByMood;

public class GetModelsByMoodQueryResponse : BaseResponse
{
    public List<GetModelsByMoodQueryDto> Models { get; set; } = [];
}