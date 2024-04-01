using FluentValidation;

namespace MB.Application.Features.Relations.Commands.RAS
{
    public class CreateRelationsArtistStyleCommandValidator : AbstractValidator<CreateRelationsArtistStyleCommand>
    {
        public CreateRelationsArtistStyleCommandValidator()
        {
            RuleFor(command => command.ArtistId)
                .NotEmpty().WithMessage("L'identifiant de l'artiste ne doit pas être vide.");

            RuleFor(command => command.StyleIds)
                .NotEmpty().WithMessage("La liste des styles ne doit pas être vide.")
                .Must(styleIds => styleIds.All(styleId => styleId != Guid.Empty))
                .WithMessage("Un ou plusieurs identifiants de style sont invalides.");
        }
    }
}