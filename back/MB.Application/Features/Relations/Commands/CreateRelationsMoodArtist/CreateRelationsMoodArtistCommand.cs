using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsMoodArtist;

public class CreateRelationsMoodArtistCommand : IRequest<BaseResponse>
{
    public Guid MoodId { get; set; }
    public List<Guid> ArtistIds { get; set; } = [];
}
