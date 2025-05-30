namespace MB.Application.Features.Moods.Queries;

public class MoodLightDto
{
    public Guid BusinessId { get; set; }
    public int Type { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public string Extension { get; set; } = "";
    public int Score { get; set; }
    public int Position { get; set; }

    public int? Width { get; set; }
    public int? Height { get; set; }
    public int? Duration { get; set; }
    public int? Size { get; set; }

    public string? Url { get; set; }

    public string? ThumbnailUrl { get; set; }
    public string? EmbedUrl { get; set; }
}