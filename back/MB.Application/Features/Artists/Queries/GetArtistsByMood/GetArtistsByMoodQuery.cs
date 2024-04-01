using MediatR;

namespace MB.Application.Features.Artists.Queries.GetArtistsByMood
{
    public class GetArtistsByMoodQuery : IRequest<GetArtistsByMoodQueryResponse>
    {
        public Guid BusinessId { get; set; } = Guid.Empty;
    }
}