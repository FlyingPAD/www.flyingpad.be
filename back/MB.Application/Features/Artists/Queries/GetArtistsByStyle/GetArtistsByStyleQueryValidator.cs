using FluentValidation;

namespace MB.Application.Features.Artists.Queries.GetArtistsByStyle;

public class GetArtistsByStyleQueryValidator : AbstractValidator<GetArtistsByStyleQuery>
{
    public GetArtistsByStyleQueryValidator()
    {
        RuleFor(request => request.StyleId)
            .NotEmpty().WithMessage("StyleId is required.")
            .NotEqual(Guid.Empty).WithMessage("StyleId must not be empty.");
    }
}