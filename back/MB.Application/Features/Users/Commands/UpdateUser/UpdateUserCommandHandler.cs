using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence.Definitions;
using MB.Domain.AchievementAggregate;
using MediatR;

namespace MB.Application.Features.Users.Commands.UpdateUser;

public class UpdateUserCommandHandler(
    IMapper mapper,
    IUserRepository userRepository,
    IAchievementDefinitionsRepository achDefRepo) : IRequestHandler<UpdateUserCommand, UpdateUserCommandResponse>
{
    private readonly IMapper _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    private readonly IUserRepository _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
    private readonly IAchievementDefinitionsRepository _achDefRepo = achDefRepo ?? throw new ArgumentNullException(nameof(achDefRepo));

    public async Task<UpdateUserCommandResponse> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        // 1) Récupérer l'utilisateur par BusinessId
        var user = await _userRepository
            .GetByBusinessIdWithAchievementsAsync(request.BusinessId)
            ?? throw new NotFoundException("User not found.");

        // 2) Appliquer la mise à jour métier
        user.UpdateProfile(request.UserName, request.FirstName, request.LastName, request.Birthdate);

        // 3) Si le profil est complet, débloquer ProfileCompleted
        bool isComplete =
               !string.IsNullOrWhiteSpace(user.UserName)
            && !string.IsNullOrWhiteSpace(user.FirstName)
            && !string.IsNullOrWhiteSpace(user.LastName)
            && user.Birthdate.HasValue;

        if (isComplete)
        {
            var profileDef = await _achDefRepo.GetByCodeAsync(AchievementCodes.ProfileCompleted);
            if (profileDef != null)
            {
                user.UnlockAchievement(profileDef);
            }
        }

        // 4) Persister TOUT le graphe (user + nouveaux achievements)
        await _userRepository.UpdateAggregateAsync(user);

        // 5) Retourner le DTO mis à jour
        return new UpdateUserCommandResponse
        {
            Success = true,
            Message = "User updated successfully.",
            UpdatedUser = _mapper.Map<UpdateUserCommandDto>(user)
        };
    }
}