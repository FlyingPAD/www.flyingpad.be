using MediatR;

namespace MB.Application.Features.Medias.Commands.CreateMedium;

public class CreateMediumCommand : IRequest<CreateMediumCommandResponse>
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}