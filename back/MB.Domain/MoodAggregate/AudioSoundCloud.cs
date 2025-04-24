namespace MB.Domain.MoodAggregate;

public class AudioSoundCloud : Mood
{
    public string Url { get; set; } = string.Empty;
    public string ThumbnailUrl { get; set; } = string.Empty;
    public string EmbedUrl { get; set; } = string.Empty;
}