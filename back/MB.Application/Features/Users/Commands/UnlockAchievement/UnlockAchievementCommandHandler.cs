using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MB.Domain.AchievementAggregate;
using MediatR;

namespace MB.Application.Features.Users.Commands.UnlockAchievement;

public class UnlockAchievementCommandHandler(
    IUserRepository userRepo,
    IAchievementDefinitionsRepository defRepo,
    ILevelDefinitionRepository levelDefRepo)
            : IRequestHandler<UnlockAchievementCommand, BaseResponse>
{
    private readonly IUserRepository _userRepo = userRepo ?? throw new ArgumentNullException(nameof(userRepo));
    private readonly IAchievementDefinitionsRepository _defRepo = defRepo ?? throw new ArgumentNullException(nameof(defRepo));
    private readonly ILevelDefinitionRepository _levelDefRepo = levelDefRepo ?? throw new ArgumentNullException(nameof(levelDefRepo));

    public async Task<BaseResponse> Handle(
        UnlockAchievementCommand request,
        CancellationToken cancellationToken)
    {
        // 1) Récupérer l’utilisateur avec ses achievements existants
        var user = await _userRepo
            .GetByBusinessIdWithAchievementsAsync(request.UserBusinessId)
            ?? throw new NotFoundException("User not found.");

        // 2) Récupérer la définition de l’achievement par son code
        var def = await _defRepo.GetByCodeAsync(request.AchievementCode)
                  ?? throw new NotFoundException("AchievementDefinition not found.");

        // 3) Débloquer l’achievement (évite les doublons)
        user.UnlockAchievement(def);

        // 4) Recalculer le niveau et débloquer le succès de niveau si nécessaire
        var levelDefs = await _levelDefRepo.GetAllAsync();
        var levelCodes = levelDefs.Select(ld => AchievementCodes.LevelReached(ld.LevelNumber)).ToList();
        var levelAchDefs = await _defRepo.GetByCodesAsync(levelCodes);

        user.RecalculateLevel(
            levelDefs,
            AchievementCodes.LevelReached,
            code => levelAchDefs.SingleOrDefault(a => a.Code == code)
        );

        // 5) Persister l’agrégat
        await _userRepo.UpdateAggregateAsync(user);

        return new BaseResponse
        {
            Success = true,
            Message = "Achievement unlocked."
        };
    }
}