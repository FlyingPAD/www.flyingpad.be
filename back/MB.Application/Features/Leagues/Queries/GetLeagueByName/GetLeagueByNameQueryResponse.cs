using MB.Application.Models;

namespace MB.Application.Features.Leagues.Queries.GetLeagueByName;

public class GetLeagueByNameQueryResponse : BaseResponse
{
    public LeagueWithRankingDto? League { get; set; }
}