using MB.Application.Models;

namespace MB.Application.Features.Moods.Queries.GetNewMoods;

public class GetNewMoodsQueryResponse : BaseResponse
{
    public List<MoodLightDto> Moods { get; set; } = [];
}