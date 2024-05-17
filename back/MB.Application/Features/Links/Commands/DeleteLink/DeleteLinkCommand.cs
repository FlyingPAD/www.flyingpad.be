using MediatR;

namespace MB.Application.Features.Links.Commands.DeleteLink;

public class DeleteLinkCommand : IRequest<DeleteLinkCommandResponse>
{
    public Guid LinkId { get; set; }
}
