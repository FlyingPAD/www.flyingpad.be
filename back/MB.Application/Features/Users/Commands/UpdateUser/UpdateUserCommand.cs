using MediatR;

namespace MB.Application.Features.Users.Commands.UpdateUser;

public class UpdateUserCommand : IRequest<UpdateUserCommandResponse>
{
    public Guid BusinessId { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime Birthdate { get; set; }
}