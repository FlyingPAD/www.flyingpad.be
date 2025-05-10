using MB.Application.Models;

namespace MB.Application.Features.Moods.Queries.GetMoodsByTagCategory;

public class GetMoodsByTagCategoryQueryResponse : BaseResponse
{
    public List<MoodLightDto> Moods { get; set; } = [];
}