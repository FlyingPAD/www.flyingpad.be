using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MB.Domain.AchievementAggregate;
using MediatR;

namespace MB.Application.Features.Users.Commands.GainExperience;

public class GainExperienceCommandHandler(
    IUserRepository userRepo,
    ILevelDefinitionRepository levelDefRepo,
    IAchievementDefinitionsRepository achievementDefRepo
) : IRequestHandler<GainExperienceCommand, BaseResponse>
{
    private readonly IUserRepository _userRepo = userRepo;
    private readonly ILevelDefinitionRepository _levelDefRepo = levelDefRepo;
    private readonly IAchievementDefinitionsRepository _achievementDefRepo = achievementDefRepo;

    public async Task<BaseResponse> Handle(GainExperienceCommand request, CancellationToken cancellationToken)
    {
        // 1) Charger l’utilisateur avec ses achievements
        var user = await _userRepo.GetByBusinessIdWithAchievementsAsync(request.UserBusinessId)
                   ?? throw new NotFoundException("Utilisateur introuvable.");

        // 2) Incrémenter l'XP
        user.GainExperience(request.Xp);

        // 3) Précharger définitions de niveaux et d’achievements de niveau
        var levelDefs = await _levelDefRepo.GetAllAsync();
        var levelCodes = levelDefs.Select(ld => AchievementCodes.LevelReached(ld.LevelNumber));
        var levelAchDefs = await _achievementDefRepo.GetByCodesAsync(levelCodes);

        // 4) Recalculer le niveau et débloquer automatiquement le succès de niveau
        user.RecalculateLevel(
            levelDefs,
            AchievementCodes.LevelReached,
            code => levelAchDefs.SingleOrDefault(a => a.Code == code)
        );

        // 5) Persister l’utilisateur (les nouveaux achievements sont inclus dans _achievements)
        await _userRepo.UpdateAsync(user);

        return new BaseResponse
        {
            Success = true,
            Message = "Experience ajoutée et niveau mis à jour si nécessaire."
        };
    }
}