using MediatR;

namespace MB.Application.Features.Users.Commands.DeleteUser
{
    public class DeleteUserCommand : IRequest<DeleteUserCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
