using MediatR;

namespace MB.Application.Features.Users.Commands.UpdateUser
{
    public class UpdateUserCommand : IRequest<UpdateUserCommandResponse>
    {
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public Guid BusinessId { get; set; }
        public DateTime Birthdate { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}