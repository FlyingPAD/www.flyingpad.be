namespace MB.Application.Features.Seasons.Queries.GetCurrentSeason;

public class GetCurrentSeasonQueryDto
{
    public string Name { get; set; } = string.Empty;
    public DateTime StartsAt { get; set; }
    public DateTime EndsAt { get; set; }
}