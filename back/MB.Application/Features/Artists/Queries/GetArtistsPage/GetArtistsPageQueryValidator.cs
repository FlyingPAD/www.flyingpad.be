using FluentValidation;

namespace MB.Application.Features.Artists.Queries.GetArtistsPage;

public class GetArtistsPageQueryValidator : AbstractValidator<GetArtistsPageQuery>
{
    public GetArtistsPageQueryValidator()
    {
        // Valide que PageSize est entre 10 et 50.
        RuleFor(q => q.PageSize)
            .InclusiveBetween(10, 50).WithMessage("La taille de page doit être comprise entre 10 et 50.");

        // Valide que Abc peut être une chaîne vide ou contenir uniquement des caractères alphabétiques.
        RuleFor(q => q.Abc)
            .Matches("^[a-zA-Z]*$").WithMessage("La chaîne de recherche 'Abc' doit uniquement contenir des lettres alphabétiques ou être une chaîne vide.")
            .MaximumLength(50).WithMessage("La chaîne de recherche 'Abc' doit contenir au maximum 50 caractères.");

        // Valide que StyleId et StartId, s'ils sont fournis, ne sont pas des GUID vides.
        RuleFor(q => q.StyleId)
            .NotEmpty().When(q => q.StyleId.HasValue)
            .WithMessage("L'identifiant de style doit être un GUID non vide.");

        RuleFor(q => q.StartId)
            .NotEmpty().When(q => q.StartId.HasValue)
            .WithMessage("L'identifiant de départ doit être un GUID non vide.");
    }
}
