using MediatR;

namespace MB.Application.Features.Moods.Queries.GetMoodsByArtist;

public class GetMoodsByArtistQuery : IRequest<GetMoodsByArtistQueryResponse>
{
    public Guid ArtistId { get; set; }
}
