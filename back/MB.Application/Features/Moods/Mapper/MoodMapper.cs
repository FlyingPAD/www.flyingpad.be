using MB.Application.Features.Moods.Queries;
using MB.Domain.MoodAggregate;

namespace MB.Application.Features.Moods.Mapper;

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
                Url = null,
                Width = null,
                Height = null,
                Duration = null,
                Size = null
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
                    dto.Url = yt.Url;
                    break;
            }

            list.Add(dto);
        }

        return list;
    }
}