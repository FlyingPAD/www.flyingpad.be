using MediatR;

namespace MB.Application.Features.Links.Commands.UpdateLink;

public class UpdateLinkCommand : IRequest<UpdateLinkCommandResponse>
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
