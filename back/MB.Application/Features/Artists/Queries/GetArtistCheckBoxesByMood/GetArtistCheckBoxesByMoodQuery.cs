using MediatR;

namespace MB.Application.Features.Artists.Queries.GetArtistCheckBoxesByMood
{
    public class GetArtistCheckBoxesByMoodQuery : IRequest<GetArtistCheckBoxesByMoodQueryResponse>
    {
        public Guid MoodId { get; set; } = Guid.Empty;
    }
}
