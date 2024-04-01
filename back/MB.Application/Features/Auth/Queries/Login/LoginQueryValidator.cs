using FluentValidation;
using MB.Application.Features.Auth.Queries.Login;

public class LoginQueryValidator : AbstractValidator<LoginQuery>
{
    public LoginQueryValidator()
    {
        RuleFor(query => query.Email)
            .NotEmpty().WithMessage("L'email est obligatoire.")
            .EmailAddress().WithMessage("L'email n'est pas dans un format valide.");

        RuleFor(query => query.Password)
            .NotEmpty().WithMessage("Le mot de passe est obligatoire.");
    }
}
