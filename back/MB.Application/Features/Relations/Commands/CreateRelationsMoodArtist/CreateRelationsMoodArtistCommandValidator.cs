using FluentValidation;

namespace MB.Application.Features.Relations.Commands.CreateRelationsMoodArtist;

public class CreateRelationsMoodArtistCommandValidator : AbstractValidator<CreateRelationsMoodArtistCommand>
{
    public CreateRelationsMoodArtistCommandValidator()
    {
        RuleFor(request => request.MoodId)
            .NotEmpty().WithMessage("MoodId must not be Empty.");

        RuleFor(request => request.ArtistIds)
            .NotEmpty().WithMessage("Artists list must not be empty.")
            .Must(artistIds => artistIds.All(artistId => artistId != Guid.Empty))
            .WithMessage("One or more invalid Id('s).");
    }
}