using MediatR;

namespace MB.Application.Features.Artists.Commands.CreateArtist;

public class CreateArtistCommand : IRequest<CreateArtistCommandResponse>
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<Guid> StyleIds { get; set; } = [];
}