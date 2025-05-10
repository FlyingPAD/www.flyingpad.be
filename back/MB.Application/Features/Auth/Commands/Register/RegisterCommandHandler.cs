using MB.Application.Interfaces.Infrastructure;
using MB.Application.Interfaces.Persistence;
using MB.Application.Interfaces.Services;
using MB.Domain.AchievementAggregate;
using MB.Domain.LeagueAggregate;
using MB.Domain.UserAggregate.Interfaces;
using MediatR;

namespace MB.Application.Features.Auth.Commands.Register;

public class RegisterCommandHandler(
    IAuthRepository authRepository,
    ITokenManager tokenManager,
    ICaptchaValidator captchaValidator,
    IUserFactory userFactory,
    IBaseRepository<AchievementDefinition> achievementDefRepo,
    IBaseRepository<LeagueDefinition> leagueDefRepo,
    ISeasonRepository seasonRepo,
    IUserRepository userRepo) : IRequestHandler<RegisterCommand, RegisterCommandResponse>
{
    private readonly IAuthRepository _authRepository = authRepository;
    private readonly ITokenManager _tokenManager = tokenManager;
    private readonly ICaptchaValidator _captchaValidator = captchaValidator;
    private readonly IUserFactory _userFactory = userFactory;
    private readonly IBaseRepository<AchievementDefinition> _achievementDefRepo = achievementDefRepo;
    private readonly IBaseRepository<LeagueDefinition> _leagueDefRepo = leagueDefRepo;
    private readonly ISeasonRepository _seasonRepo = seasonRepo;
    private readonly IUserRepository _userRepo = userRepo;

    public async Task<RegisterCommandResponse> Handle(
        RegisterCommand request,
        CancellationToken cancellationToken)
    {
        // 1) Validation reCAPTCHA
        bool captchaOk = request.CaptchaType == "v2"
            ? await _captchaValidator.VerifyV2Async(request.CaptchaToken)
            : await _captchaValidator.VerifyV3Async(request.CaptchaToken, "register");
        if (!captchaOk)
        {
            return new RegisterCommandResponse(null)
            {
                Success = false,
                Message = "La validation reCAPTCHA a échoué.",
                NeedV2 = request.CaptchaType == "v3"
            };
        }

        // 2) Vérifier que l'email n'existe pas déjà
        if (await _authRepository.UserExists(request.Email))
        {
            return new RegisterCommandResponse(null)
            {
                Success = false,
                Message = "Cet email est déjà utilisé."
            };
        }

        // 3) Création initiale et enregistrement de l'utilisateur
        var user = _userFactory.Create(
            userName: request.UserName,
            firstName: request.FirstName,
            lastName: request.LastName,
            email: request.Email,
            plainPassword: request.Pass,
            birthdate: request.Birthdate ?? default
        );
        var registeredUser = await _authRepository.RegisterAsync(user);

        // 4) Affecter la saison en cours
        var currentSeason = await _seasonRepo.GetCurrentSeasonAsync(DateTime.UtcNow);
        if (currentSeason is not null)
        {
            registeredUser.ParticipateInSeason(currentSeason);
        }

        // 5) Placer directement en ligue "Wood"
        var allLeagues = await _leagueDefRepo.GetAllAsync();
        var woodLeague = allLeagues
            .FirstOrDefault(l => l.MinExperience == 0 && l.Order == 1);
        if (woodLeague is not null)
        {
            registeredUser.UpdateLeague(woodLeague);
        }

        // 6) Débloquer l'achievement « Official Member »
        var officialDef = await _achievementDefRepo
            .GetByBusinessIdAsync(Guid.Parse("f47ac10b-58cc-4372-a567-0e02b2c3d479"));
        if (officialDef is not null)
        {
            registeredUser.UnlockAchievement(officialDef);
        }

        // 7) Sauvegarde finale
        await _userRepo.UpdateAsync(registeredUser);

        // 8) Génération du token JWT
        var token = _tokenManager.GenerateToken(registeredUser);

        // 9) Réponse
        return new RegisterCommandResponse(token)
        {
            Success = true,
            Message = "Welcome !"
        };
    }
}