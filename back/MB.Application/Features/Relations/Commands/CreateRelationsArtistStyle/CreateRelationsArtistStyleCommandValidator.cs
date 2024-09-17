using FluentValidation;

namespace MB.Application.Features.Relations.Commands.RAS;

public class CreateRelationsArtistStyleCommandValidator : AbstractValidator<CreateRelationsArtistStyleCommand>
{
    public CreateRelationsArtistStyleCommandValidator()
    {
        RuleFor(request => request.ArtistId)
            .NotEmpty().WithMessage("ArtistId must not be empty.");

        RuleFor(request => request.StyleIds)
            .NotEmpty().WithMessage("Styles list must not be empty.")
            .Must(styleIds => styleIds.All(styleId => styleId != Guid.Empty))
            .WithMessage("One or more invalid Id('s).");
    }
}