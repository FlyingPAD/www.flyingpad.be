namespace MB.Application.Features.Leagues.Queries.GetLeagueByName;

public class LeagueWithRankingDto
{
    public Guid BusinessId { get; init; }
    public string LeagueName { get; init; } = default!;
    public string? IconCssClass { get; init; }
    public int MinExperience { get; set; }
    public int? MaxExperience { get; set; }
    public int Order { get; init; }
    public IReadOnlyList<LeagueMemberDto> Members { get; init; } = [];
}