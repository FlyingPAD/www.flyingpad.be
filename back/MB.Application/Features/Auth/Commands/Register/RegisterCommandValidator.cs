using FluentValidation;

namespace MB.Application.Features.Auth.Commands.Register;

public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
{
    public RegisterCommandValidator()
    {
        RuleFor(request => request.Email)
            .NotEmpty().WithMessage("Le nom d'utilisateur est obligatoire.")
            .MaximumLength(254).WithMessage("Le nom d'utilisateur ne doit pas dépasser 254 caractères.");

        RuleFor(request => request.Pass)
            .NotEmpty().WithMessage("Le mot de passe est obligatoire.")
            .MinimumLength(8).WithMessage("Le mot de passe doit contenir au moins 8 caractères.");

        RuleFor(request => request.ConfirmPass)
            .Equal(x => x.Pass).WithMessage("Les mots de passe doivent correspondre.");

        RuleFor(request => request.CaptchaToken)
            .NotEmpty().WithMessage("Le jeton reCAPTCHA est obligatoire.");

        RuleFor(request => request.CaptchaType)
            .Must(t => t == "v2" || t == "v3")
            .WithMessage("Le type de captcha doit être 'v2' ou 'v3'.");
    }
}