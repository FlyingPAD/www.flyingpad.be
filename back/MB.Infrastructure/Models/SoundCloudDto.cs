using System.Text.Json.Serialization;

namespace MB.Infrastructure.Models;

public class SoundCloudDto
{
    [JsonPropertyName("thumbnail_url")]
    public string ThumbnailUrl { get; set; } = string.Empty;

    [JsonPropertyName("html")]
    public string Html { get; set; } = string.Empty;
}