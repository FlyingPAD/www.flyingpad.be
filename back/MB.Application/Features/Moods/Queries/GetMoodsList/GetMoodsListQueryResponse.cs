using MB.Application.Responses;

namespace MB.Application.Features.Moods.Queries.GetMoodsList;

public class GetMoodsListQueryResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    /// 
    public List<MoodListVm> MoodsList { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public GetMoodsListQueryResponse() : base()
    {

    }
}
