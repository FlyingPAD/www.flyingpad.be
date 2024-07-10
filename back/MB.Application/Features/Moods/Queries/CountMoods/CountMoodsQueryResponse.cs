namespace MB.Application.Features.Moods.Queries.CountMoods;

public class CountMoodsQueryResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public int MoodsCount { get; set; }

    public CountMoodsQueryResponse() : base ()
    {

    }
}
