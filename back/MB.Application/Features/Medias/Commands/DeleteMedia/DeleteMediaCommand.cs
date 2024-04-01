using MediatR;

namespace MB.Application.Features.Medias.Commands.DeleteMedia
{
    public class DeleteMediaCommand : IRequest<DeleteMediaCommandResponse>
    {
        public Guid MediaId { get; set; }
    }
}
