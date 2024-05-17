using FluentValidation;

namespace MB.Application.Features.Relations.Commands.RAS;

public class CreateRelationsArtistStyleCommandValidator : AbstractValidator<CreateRelationsArtistStyleCommand>
{
    public CreateRelationsArtistStyleCommandValidator()
    {
        RuleFor(command => command.ArtistId)
            .NotEmpty().WithMessage("Artist ID must not be empty.");

        RuleFor(command => command.StyleIds)
            .NotEmpty().WithMessage("List must not be empty.")
            .Must(styleIds => styleIds.All(styleId => styleId != Guid.Empty))
            .WithMessage("One or more invalid ID(s).");
    }
}