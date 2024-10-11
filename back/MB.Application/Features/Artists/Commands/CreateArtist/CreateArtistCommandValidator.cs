using FluentValidation;

namespace MB.Application.Features.Artists.Commands.CreateArtist;

public class CreateArtistCommandValidator : AbstractValidator<CreateArtistCommand>
{
    public CreateArtistCommandValidator()
    {
        RuleFor(request => request.Name)
            .NotEmpty().WithMessage("Name is required.")
            .NotNull()
            .MaximumLength(30).WithMessage("Name must not exceed 30 characters.");

        RuleFor(request => request.Description)
            .NotEmpty().WithMessage("Description is required.")
            .NotNull()
            .MaximumLength(75).WithMessage("Description must not exceed 75 characters.");

        RuleFor(request => request.StyleIds)
            .NotNull().WithMessage("At least one style must be selected.")
            .NotEmpty().WithMessage("StyleIds must contain at least one element.")
            .ForEach(styleId => styleId.NotEqual(Guid.Empty).WithMessage("Invalid style identifier."));
    }
}