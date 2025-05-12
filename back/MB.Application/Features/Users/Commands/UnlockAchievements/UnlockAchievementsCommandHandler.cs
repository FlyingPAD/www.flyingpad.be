using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MB.Domain.AchievementAggregate;
using MediatR;

namespace MB.Application.Features.Users.Commands.UnlockAchievements;

public class UnlockAchievementsCommandHandler(
    IUserRepository userRepo,
    IAchievementDefinitionsRepository defRepo,
    ILevelDefinitionRepository levelDefRepo)
        : IRequestHandler<UnlockAchievementsCommand, BaseResponse>
{
    private readonly IUserRepository _userRepo = userRepo ?? throw new ArgumentNullException(nameof(userRepo));
    private readonly IAchievementDefinitionsRepository _defRepo = defRepo ?? throw new ArgumentNullException(nameof(defRepo));
    private readonly ILevelDefinitionRepository _levelDefRepo = levelDefRepo ?? throw new ArgumentNullException(nameof(levelDefRepo));

    public async Task<BaseResponse> Handle(
        UnlockAchievementsCommand request,
        CancellationToken cancellationToken)
    {
        // 1) Charger l’utilisateur avec ses achievements existants
        var user = await _userRepo
            .GetByBusinessIdWithAchievementsAsync(request.UserBusinessId)
            ?? throw new NotFoundException("User not found.");

        // 2) Récupérer les définitions demandées
        var defs = await _defRepo.GetByCodesAsync(request.AchievementCodes);
        if (!defs.Any())
        {
            return new BaseResponse
            {
                Success = false,
                Message = "No valid achievement definitions found."
            };
        }

        // 3) Débloquer les achievements demandés
        foreach (var def in defs)
        {
            user.UnlockAchievement(def);
        }

        // 4) Recalculer le niveau et débloquer le succès de niveau si nécessaire
        var levelDefs = await _levelDefRepo.GetAllAsync();
        var levelCodes = levelDefs
            .Select(ld => AchievementCodes.LevelReached(ld.LevelNumber))
            .ToList();
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
            Message = $"Unlocked {defs.Count} achievement(s)."
        };
    }
}