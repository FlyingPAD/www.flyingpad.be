using FluentValidation;

namespace MB.Application.Features.Artists.Commands.DeleteArtist;

public class DeleteArtistCommandValidator : AbstractValidator<DeleteArtistCommand>
{
    public DeleteArtistCommandValidator()
    {
        RuleFor(request => request.ArtistId)
            .NotEmpty().WithMessage("ArtistId is required.")
            .NotEqual(Guid.Empty).WithMessage("ArtistId must not be empty.");
    }
}