using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Relations.Commands.RAS;

public class CreateRelationsArtistStyleCommand : IRequest<BaseResponse>
{
    public Guid ArtistId { get; set; }
    public List<Guid> StyleIds { get; set; } = [];
}   