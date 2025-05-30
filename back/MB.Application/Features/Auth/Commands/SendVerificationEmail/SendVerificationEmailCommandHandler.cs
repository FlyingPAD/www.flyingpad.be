using MB.Application.Interfaces.Infrastructure;
using MB.Application.Interfaces.Persistence;
using MB.Application.Interfaces.Persistence.Definitions;
using MB.Application.Models;
using MB.Domain.UserAggregate;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace MB.Application.Features.Auth.Commands.SendVerificationEmail
{
    public class SendVerificationEmailCommandHandler(
        IHttpContextAccessor httpContextAccessor,
        IBaseRepository<User> userRepo,
        IEmailVerificationTokenRepository tokenRepo,
        IEMailService emailService,
        IConfiguration configuration
    ) : IRequestHandler<SendVerificationEmailCommand, BaseResponse>
    {
        private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;
        private readonly IBaseRepository<User> _userRepo = userRepo;
        private readonly IEmailVerificationTokenRepository _tokenRepo = tokenRepo;
        private readonly IEMailService _emailService = emailService;
        private readonly IConfiguration _configuration = configuration;

        public async Task<BaseResponse> Handle(
            SendVerificationEmailCommand request,
            CancellationToken cancellationToken)
        {
            // 1) Lire la claim "businessId" (GUID)
            var businessIdClaim = _httpContextAccessor.HttpContext?.User
                .FindFirst("businessId")?.Value;
            if (!Guid.TryParse(businessIdClaim, out var businessId))
                return new BaseResponse
                {
                    Success = false,
                    Message = "Utilisateur non authentifié."
                };

            // 2) Charger l'utilisateur via son BusinessId
            var user = await _userRepo.GetByBusinessIdAsync(businessId);
            if (user == null)
                return new BaseResponse
                {
                    Success = false,
                    Message = "Utilisateur introuvable."
                };

            // 3) Générer et stocker le token de vérification
            var tokenValue = Guid.NewGuid().ToString("N");
            var tokenEntity = new EmailVerificationToken
            {
                UserId = user.EntityId,       // clé étrangère vers PK User
                Token = tokenValue,
                CreatedAt = DateTimeOffset.UtcNow,
                ExpiresAt = DateTimeOffset.UtcNow.AddHours(24)
            };
            await _tokenRepo.CreateAsync(tokenEntity);

            // 4) Construire le lien et envoyer l'email
            var frontendUrl = _configuration["Frontend:BaseUrl"]
                              ?? throw new InvalidOperationException("Frontend:BaseUrl non configuré.");
            var confirmationLink = $"{frontendUrl}/confirm-email/{tokenValue}";

            var body = $@"
                <p>Bonjour {user.FirstName},</p>
                <p>Pour confirmer votre adresse email, cliquez sur le lien suivant :</p>
                <p><a href=""{confirmationLink}"">Confirmer mon email</a></p>
                <p>Ce lien expire dans 24 heures.</p>";

            await _emailService.SendEmailAsync(user.Email, "Vérification de votre email", body);

            return new BaseResponse
            {
                Success = true,
                Message = "Email de vérification envoyé."
            };
        }
    }
}