using MB.Application.Models;

namespace MB.Application.Features.Moods.Queries.GetAllMoods;

public class GetAllMoodsQueryResponse : BaseResponse
{
    public List<MoodLightDto> Moods { get; set; } = [];
}