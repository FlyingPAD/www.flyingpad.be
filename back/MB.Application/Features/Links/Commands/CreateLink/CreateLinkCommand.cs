using MediatR;

namespace MB.Application.Features.Links.Commands.CreateLink;

public class CreateLinkCommand : IRequest<CreateLinkCommandResponse>
{
    public string Name { get; set; } = string.Empty;
}
