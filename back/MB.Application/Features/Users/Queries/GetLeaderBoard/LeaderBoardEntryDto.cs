namespace MB.Application.Features.Users.Queries.GetLeaderboard;

public class LeaderboardEntryDto
{
    public string BusinessId { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public int Level { get; set; }
    public int Experience { get; set; }
    public int SeasonScore { get; set; }
    public string LeagueName { get; set; } = string.Empty;
}