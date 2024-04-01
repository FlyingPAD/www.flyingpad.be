using MediatR;

namespace MB.Application.Features.Users.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<CreateUserCommandResponse>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}
