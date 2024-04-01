using MediatR;

namespace MB.Application.Features.Tasks.Commands.DeleteTask
{
    public class DeleteTaskCommand : IRequest<DeleteTaskCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
