namespace MB.Application.Features.Leagues.Queries.GetLeagueByName;

public class LeagueMemberDto
{
    public Guid BusinessId { get; init; }
    public string UserName { get; init; } = default!;
    public int SeasonScore { get; init; }
}