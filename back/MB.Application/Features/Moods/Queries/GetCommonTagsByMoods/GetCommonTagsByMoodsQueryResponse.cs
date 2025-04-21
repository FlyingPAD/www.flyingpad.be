namespace MB.Application.Features.Moods.Queries.GetCommonTagsByMoods;

public class GetCommonTagsByMoodsQueryResponse : BaseResponse
{
    public List<GetCommonTagsByMoodsQueryDto> CommonTags { get; set; } = [];
}