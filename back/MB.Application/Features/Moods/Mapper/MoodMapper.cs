using MB.Application.Features.Moods.Queries;
using MB.Domain.MoodAggregate;

public static class MoodMapper
{
    public static List<MoodLightDto> ToListItemDtos(IEnumerable<Mood> moods)
    {
        var list = new List<MoodLightDto>();
        foreach (var m in moods)
        {
            var dto = new MoodLightDto
            {
                BusinessId = m.BusinessId,
                Type = m.Type,
                Name = m.Name,
                Description = m.Description,
                Extension = m.Extension,
                Score = m.Score,
                Width = null,
                Height = null,
                Duration = null,
                Size = null,
                Url = null,
                ThumbnailUrl = null,
                EmbedUrl = null
            };

            switch (m)
            {
                case Image img:
                    dto.Width = img.Width;
                    dto.Height = img.Height;
                    dto.Size = img.Size;
                    break;

                case Video vid:
                    dto.Width = vid.Width;
                    dto.Height = vid.Height;
                    dto.Duration = vid.Duration;
                    dto.Size = vid.Size;
                    break;

                case Document doc:
                    dto.Size = doc.Size;
                    break;

                case VideoYouTube yt:
                    // Url stocke ici l'ID YouTube
                    dto.Url = yt.Url;
                    break;

                case MB.Domain.MoodAggregate.AudioSoundCloud sc:
                    // On alimente les deux nouvelles props
                    dto.ThumbnailUrl = sc.ThumbnailUrl;
                    dto.EmbedUrl = sc.EmbedUrl;
                    break;
            }

            list.Add(dto);
        }

        return list;
    }
}