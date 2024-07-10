namespace MB.Application.Features.Moods.Queries.GetMoodsList;

public class GetMoodsListQueryResponse : BaseResponse
{
    public List<MoodListVm> Moods { get; set; } = [];
}
