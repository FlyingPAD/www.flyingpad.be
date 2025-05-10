using MB.Application.Interfaces.Persistence;
using MB.Domain.AchievementAggregate;
using MediatR;

namespace MB.Application.Features.Users.Queries.GetUserAchievements;

public class GetUserAchievementsQueryHandler(
    IBaseRepository<AchievementDefinition> defRepo,
    IUserRepository userRepo)
        : IRequestHandler<GetUserAchievementsQuery, GetUserAchievementsQueryResponse>
{
    private readonly IBaseRepository<AchievementDefinition> _defRepo = defRepo;
    private readonly IUserRepository _userRepo = userRepo;

    public async Task<GetUserAchievementsQueryResponse> Handle(
        GetUserAchievementsQuery request,
        CancellationToken cancellationToken)
    {
        // 1) Définitions triées par EntityId
        var defsQ = await _defRepo.GetAllAsync(
            orderBy: def => def.EntityId,
            ascending: true
        );
        var definitions = defsQ.ToList();

        // 2) Achievements débloqués de l’utilisateur
        var user = await _userRepo
            .GetByBusinessIdWithAchievementsAsync(request.UserId)
            ?? throw new KeyNotFoundException("User not found.");

        var unlocked = user.Achievements
            .ToDictionary(ua => ua.Definition.BusinessId, ua => ua.UnlockedAt);

        // 3) Fusion
        var all = definitions
            .Select(def => new GetUserAchievementsQueryDto
            {
                BusinessId = def.BusinessId,
                Title = def.Title,
                Goal = def.Goal,
                DoneMessage = def.DoneMessage,
                Category = def.Category,
                XpReward = def.XpReward,
                UnlockedAt = unlocked.TryGetValue(def.BusinessId, out var dt) ? dt : null
            })
            .ToList();

        // 4) Construction de la réponse
        return new GetUserAchievementsQueryResponse
        {
            Success = true,
            Message = "Liste des achievements récupérée avec succès.",
            Achievements = all
        };
    }
}