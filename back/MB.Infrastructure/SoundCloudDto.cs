using System.Text.Json.Serialization;

namespace MB.Infrastructure;

public class SoundCloudDto
{
    [JsonPropertyName("thumbnail_url")]
    public string ThumbnailUrl { get; set; } = string.Empty;

    [JsonPropertyName("html")]
    public string Html { get; set; } = string.Empty;
}
