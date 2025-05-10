using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MB.Domain.AchievementAggregate;
using MediatR;

namespace MB.Application.Features.Users.Commands.UnlockAchievement;

public class UnlockAchievementCommandHandler(
    IUserRepository userRepo,
    IBaseRepository<AchievementDefinition> defRepo) : IRequestHandler<UnlockAchievementCommand, BaseResponse>
{
    private readonly IUserRepository _userRepo = userRepo;
    private readonly IBaseRepository<AchievementDefinition> _defRepo = defRepo;

    public async Task<BaseResponse> Handle(UnlockAchievementCommand request, CancellationToken cancellationToken)
    {
        // 1) On récupère l'utilisateur AVEC ses achievements pour que le ChangeTracker les suive
        var user = await _userRepo
            .GetByBusinessIdWithAchievementsAsync(request.UserBusinessId)
            ?? throw new NotFoundException("User not found.");

        // 2) On récupère la définition de l'achievement
        var def = await _defRepo
            .GetByBusinessIdAsync(request.AchievementBusinessId)
            ?? throw new NotFoundException("AchievementDefinition not found.");

        // 3) On applique la logique métier (vérifie qu'il n'est pas déjà débloqué)
        user.UnlockAchievement(def);

        // 4) On persiste tout l'agrégat (User + nouveaux UserAchievement)
        await _userRepo.UpdateAggregateAsync(user);

        // 5) On renvoie le résultat
        return new BaseResponse
        {
            Success = true,
            Message = "Achievement unlocked."
        };
    }
}