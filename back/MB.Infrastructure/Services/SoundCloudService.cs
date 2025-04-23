using System.Net;
using System.Net.Http.Json;
using HtmlAgilityPack;
using MB.Application.Interfaces.Infrastructure;


namespace MB.Infrastructure.Services;

public class SoundCloudOembedService : ISoundCloudService
{
    private readonly IHttpClientFactory _httpClientFactory;

    public SoundCloudOembedService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<(string ThumbnailUrl, string EmbedUrl)> GetOembedAsync(string trackUrl)
    {
        // 1) Nettoyage éventuel de l'URL
        var cleanUrl = trackUrl.Split('?')[0];

        // 2) Construction de l'URL oEmbed (format=json)
        var requestUrl =
            $"https://soundcloud.com/oembed?format=json&url={WebUtility.UrlEncode(cleanUrl)}";

        // 3) Appel HTTP
        var client = _httpClientFactory.CreateClient();
        var oembed = await client.GetFromJsonAsync<SoundCloudDto>(requestUrl)
                      ?? throw new InvalidOperationException("Réponse oEmbed nulle");

        // 4) Extraction de l'attribut src de l'iframe
        var doc = new HtmlDocument();
        doc.LoadHtml(oembed.Html);
        var iframe = doc.DocumentNode.SelectSingleNode("//iframe");
        var embedUrl = iframe?.GetAttributeValue("src", "")
                       ?? throw new InvalidOperationException("Pas d'iframe dans la réponse oEmbed");

        return (oembed.ThumbnailUrl, embedUrl);
    }
}