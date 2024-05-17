using FluentValidation;

namespace MB.Application.Features.Relations.Queries.CheckRelationsArtistStyleByArtist;

public class CheckRelationsArtistStyleByArtistQueryValidator : AbstractValidator<CheckRelationsArtistStyleByArtistQuery>
{
    public CheckRelationsArtistStyleByArtistQueryValidator()
    {
        RuleFor(query => query.ArtistId)
            .NotEmpty().WithMessage("Artist ID must not be empty.")
            .NotNull().WithMessage("Artist ID is required.");
    }
}
