using FluentValidation;

namespace MB.Application.Features.Relations.Queries.CheckRelationsArtistStyleByStyle;

public class CheckRelationsArtistStyleByStyleQueryValidator : AbstractValidator<CheckRelationsArtistStyleByStyleQuery>
{
    public CheckRelationsArtistStyleByStyleQueryValidator()
    {
        RuleFor(query => query.StyleId)
            .NotEmpty().WithMessage("Style ID must not be empty.")
            .NotNull().WithMessage("Style ID is required.");
    }
}
