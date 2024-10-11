using FluentValidation;

namespace MB.Application.Features.Artists.Commands.UpdateArtist;

public class UpdateArtistCommandValidator : AbstractValidator<UpdateArtistCommand>
{
    public UpdateArtistCommandValidator()
    {
        RuleFor(request => request.ArtistId)
            .NotEmpty().WithMessage("ArtistId is required.")
            .Must(id => id != Guid.Empty).WithMessage("ArtistId must be a valid GUID.");

        RuleFor(request => request.Name)
            .NotEmpty().WithMessage("Name is required.")
            .Length(2, 30).WithMessage("Name must be between 2 and 30 characters.");
    }
}