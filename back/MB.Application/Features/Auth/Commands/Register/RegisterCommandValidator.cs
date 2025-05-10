using FluentValidation;

namespace MB.Application.Features.Auth.Commands.Register;

public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
{
    public RegisterCommandValidator()
    {
        RuleFor(x => x.UserName)
            .NotEmpty().WithMessage("Le nom d'utilisateur est obligatoire.")
            .MaximumLength(50).WithMessage("Le nom d'utilisateur ne doit pas dépasser 50 caractères.");

        RuleFor(x => x.FirstName)
            .NotEmpty().WithMessage("Le prénom est obligatoire.");

        RuleFor(x => x.LastName)
            .NotEmpty().WithMessage("Le nom de famille est obligatoire.");

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("L'email est obligatoire.")
            .EmailAddress().WithMessage("L'email n'est pas dans un format valide.");

        RuleFor(x => x.Birthdate)
            .NotNull().WithMessage("La date de naissance est obligatoire.")
            .Must(BeAtLeast13YearsOld).WithMessage("L'utilisateur doit avoir au moins 13 ans.");

        RuleFor(x => x.Pass)
            .NotEmpty().WithMessage("Le mot de passe est obligatoire.")
            .MinimumLength(8).WithMessage("Le mot de passe doit contenir au moins 8 caractères.");

        RuleFor(x => x.ConfirmPass)
            .Equal(x => x.Pass).WithMessage("Les mots de passe doivent correspondre.");

        RuleFor(x => x.CaptchaToken)
            .NotEmpty().WithMessage("Le jeton reCAPTCHA est obligatoire.");

        RuleFor(x => x.CaptchaType)
            .Must(t => t == "v2" || t == "v3")
            .WithMessage("Le type de captcha doit être 'v2' ou 'v3'.");
    }

    private bool BeAtLeast13YearsOld(DateTime? date)
    {
        return date.HasValue && date.Value <= DateTime.Today.AddYears(-13);
    }
}