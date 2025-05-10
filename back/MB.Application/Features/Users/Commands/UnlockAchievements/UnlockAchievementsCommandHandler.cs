using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Users.Commands.UnlockAchievements;

public class UnlockAchievementsCommandHandler(IUserRepository userRepo, IAchievementDefinitionsRepository defRepo) : IRequestHandler<UnlockAchievementsCommand, BaseResponse>
{
    private readonly IUserRepository _userRepo = userRepo;
    private readonly IAchievementDefinitionsRepository _defRepo = defRepo;

    public async Task<BaseResponse> Handle(UnlockAchievementsCommand request, CancellationToken cancellationToken)
    {
        // 1) Récupérer l’utilisateur avec ses achievements
        var user = await _userRepo
            .GetByBusinessIdWithAchievementsAsync(request.UserBusinessId)
            ?? throw new NotFoundException("User not found.");

        // 2) Récupérer les définitions demandées
        var defs = await _defRepo
            .GetByBusinessIdsAsync(request.AchievementBusinessIds);

        if (!defs.Any())
        {
            return new BaseResponse
            {
                Success = false,
                Message = "No valid achievement definitions found."
            };
        }

        // 3) Débloquer chacun (la méthode évite les doublons)
        foreach (var def in defs)
        {
            user.UnlockAchievement(def);
        }

        // 4) Persister une seule fois
        await _userRepo.UpdateAggregateAsync(user);

        return new BaseResponse
        {
            Success = true,
            Message = $"Unlocked {defs.Count} achievement(s)."
        };
    }
}