using MediatR;

namespace MB.Application.Features.Users.Commands.CreateUser;

public class CreateUserCommand : IRequest<CreateUserCommandResponse>
{
    // Identité et contact
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime Birthdate { get; set; }

    // Sécurité
    public string PlainPassword { get; set; } = string.Empty;

    // Administration (UI back-office)
    public int Role { get; set; } = 1;
    public int? LeagueDefinitionId { get; set; } // nullable si pas de ligue à affecter
}