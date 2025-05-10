namespace MB.Application.Models;

public class SeasonDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime StartsAt { get; set; }
    public DateTime EndsAt { get; set; }
}