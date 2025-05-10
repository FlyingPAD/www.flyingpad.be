namespace MB.Application.Models;

public class LeagueDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
    public int MinExperience { get; set; }
    public int? MaxExperience { get; set; }
    public int Order { get; set; }
    public string? IconCssClass { get; set; }
}