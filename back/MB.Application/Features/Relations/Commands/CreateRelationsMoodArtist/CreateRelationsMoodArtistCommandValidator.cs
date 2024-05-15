using FluentValidation;

namespace MB.Application.Features.Relations.Commands.CreateRelationsMoodArtist
{
    public class CreateRelationsMoodArtistCommandValidator : AbstractValidator<CreateRelationsMoodArtistCommand>
    {
        public CreateRelationsMoodArtistCommandValidator()
        {
            RuleFor(command => command.MoodId)
                .NotEmpty().WithMessage("Mood ID must not be Empty.");

            RuleFor(command => command.ArtistIds)
                .NotEmpty().WithMessage("Artist ID's must not be Empty.")
                .Must(artistIds => artistIds.All(artistlId => artistlId != Guid.Empty))
                .WithMessage("One or more invalid ID's.");
        }
    }
}
