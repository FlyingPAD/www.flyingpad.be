using FluentValidation;

namespace MB.Application.Features.Styles.Queries.GetStylesCheckBoxesByArtist;

public class GetStylesCheckBoxesByArtistQueryValidator : AbstractValidator<GetStylesCheckBoxesByArtistQuery>
{
    public GetStylesCheckBoxesByArtistQueryValidator()
    {
        RuleFor(request => request.ArtistId)
            .NotEmpty().WithMessage("ArtistId must not be empty.")
            .NotEqual(Guid.Empty).WithMessage("ArtistId is invalid.");
    }
}