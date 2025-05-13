namespace MB.Application.Features.Leagues.Queries.GetLeagueByName;

public class LeagueMemberDto
{
    public int Id { get; init; }
    public string UserName { get; init; } = default!;
    public int SeasonScore { get; init; }
}