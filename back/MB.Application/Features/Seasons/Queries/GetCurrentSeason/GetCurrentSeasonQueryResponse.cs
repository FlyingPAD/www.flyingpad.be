using MB.Application.Models;

namespace MB.Application.Features.Seasons.Queries.GetCurrentSeason;

public class GetCurrentSeasonQueryResponse : BaseResponse
{
    public GetCurrentSeasonQueryDto? CurrentSeason { get; set; }
}