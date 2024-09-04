using MediatR;

namespace MB.Application.Features.Medias.Commands.CreateMedia;

public class CreateMediaCommand : IRequest<CreateMediaCommandResponse>
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
