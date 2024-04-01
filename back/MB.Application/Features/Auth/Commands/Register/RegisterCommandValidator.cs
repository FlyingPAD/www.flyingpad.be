using FluentValidation;

namespace MB.Application.Features.Auth.Commands.Register
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
    {
        public RegisterCommandValidator()
        {
            RuleFor(command => command.FirstName)
                .NotEmpty().WithMessage("Le prénom est obligatoire.");

            RuleFor(command => command.Email)
                .NotEmpty().WithMessage("L'email est obligatoire.")
                .EmailAddress().WithMessage("L'email n'est pas dans un format valide.");

            RuleFor(command => command.Pass)
                .NotEmpty().WithMessage("Le mot de passe est obligatoire.")
                .MinimumLength(6).WithMessage("Le mot de passe doit contenir au moins 6 caractères.");

            RuleFor(command => command.Birthdate)
                .NotNull()
                .WithMessage("La date de naissance est obligatoire.")
                .Must(BeAtLeast13YearsOld)
                .WithMessage("L'utilisateur doit avoir au moins 13 ans.");
        }

        private bool BeAtLeast13YearsOld(DateTime? date)
        {
            return date.HasValue && date.Value <= DateTime.Today.AddYears(-13);
        }
    }
}