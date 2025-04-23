namespace MB.Application.Interfaces.Infrastructure;

public interface ISoundCloudService
{
    /// <summary>
    /// Appelle l'API oEmbed SoundCloud pour une URL donnée,
    /// et retourne la vignette et l'URL du player.
    /// </summary>
    Task<(string ThumbnailUrl, string EmbedUrl)> GetOembedAsync(string trackUrl);
}