using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MB.Domain.AchievementAggregate;
using MediatR;

namespace MB.Application.Features.Auth.Commands.ConfirmEmail;

public class ConfirmEmailCommandHandler(
    IUserRepository userRepo,
    IEmailVerificationTokenRepository tokenRepo,
    IBaseRepository<AchievementDefinition> achievementDefRepo,
    IUserAchievementRepository userAchievementRepo)
        : IRequestHandler<ConfirmEmailCommand, BaseResponse>
{
    private readonly IUserRepository _userRepo = userRepo;
    private readonly IEmailVerificationTokenRepository _tokenRepo = tokenRepo;
    private readonly IBaseRepository<AchievementDefinition> _achievementDefRepo = achievementDefRepo;
    private readonly IUserAchievementRepository _userAchievementRepo = userAchievementRepo;

    public async Task<BaseResponse> Handle(
        ConfirmEmailCommand request,
        CancellationToken cancellationToken)
    {
        // 1) Récupérer l’enregistrement de token
        var record = await _tokenRepo.GetByTokenAsync(request.Token);
        if (record == null || record.ExpiresAt <= DateTimeOffset.UtcNow)
            return new BaseResponse
            {
                Success = false,
                Message = "Lien invalide ou expiré."
            };

        // 2) Charger l’utilisateur
        var user = await _userRepo.GetByIdAsync(record.UserId)
                   ?? throw new NotFoundException("Utilisateur introuvable.");

        // 3) Marquer l’email comme vérifié
        user.VerifyEmail();

        // 4) Débloquer le succès "Email Verified" (BusinessId inline)
        var emailDef = await _achievementDefRepo
            .GetByBusinessIdAsync(
                Guid.Parse("9c2f1e4a-3d7b-4f8c-9a07-1b2c3d4e5f60")
            );
        if (emailDef is not null)
        {
            // 4.1) Création du UserAchievement
            var ua = UserAchievement.Unlock(user.EntityId, emailDef);
            await _userAchievementRepo.CreateAsync(ua);

            // 4.2) Ajout de l'XP dans l'agrégat User
            user.GainExperience(emailDef.XpReward);
        }

        // 5) Persister l’utilisateur (avec le flag EmailVerified et le nouvel experience)
        await _userRepo.UpdateAsync(user);

        // 6) Expirer le token pour qu’il ne puisse plus être réutilisé
        record.ExpiresAt = DateTimeOffset.UtcNow;
        await _tokenRepo.UpdateAsync(record);

        // 7) Retour OK
        return new BaseResponse
        {
            Success = true,
            Message = "Adresse email confirmée avec succès."
        };
    }
}