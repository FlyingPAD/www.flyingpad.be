using MediatR;

namespace MB.Application.Features.Tags.Commands.DeleteTag
{
    public class DeleteTagCommand : IRequest<DeleteTagCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
