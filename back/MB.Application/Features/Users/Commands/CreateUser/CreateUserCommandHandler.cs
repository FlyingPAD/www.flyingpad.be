using MB.Application.Interfaces.Persistence;
using MB.Domain.UserAggregate.Interfaces;
using MediatR;

namespace MB.Application.Features.Users.Commands.CreateUser;

public class CreateUserCommandHandler(IUserRepository userRepository, IUserFactory userFactory) : IRequestHandler<CreateUserCommand, CreateUserCommandResponse>
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IUserFactory _userFactory = userFactory;

    public async Task<CreateUserCommandResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        // 1) Création de l’utilisateur via la factory (hachage inclus)
        var user = _userFactory.Create(
            userName: request.UserName,
            firstName: request.FirstName,
            lastName: request.LastName,
            email: request.Email,
            plainPassword: request.PlainPassword,
            birthdate: request.Birthdate
        );

        // 2) Application du rôle choisi par l’admin
        user.ChangeRole(request.Role);

        // 3) (Optionnel) Association à une ligue si fournie
        if (request.LeagueDefinitionId.HasValue)
        {
            // Vous pouvez récupérer la ligue via un autre repo, par exemple :
            // var league = await _leagueRepo.GetByIdAsync(request.LeagueDefinitionId.Value);
            // user.UpdateLeague(league);
        }

        // 4) Persistance
        var created = await _userRepository.CreateAsync(user);

        // 5) Construction de la réponse
        return new CreateUserCommandResponse
        {
            Success = true,
            Message = "User created successfully.",
            BusinessId = created.BusinessId
        };
    }
}