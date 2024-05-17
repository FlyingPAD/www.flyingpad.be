using FluentValidation;

namespace MB.Application.Features.Moods.Queries.GetMoodsByArtist;

public class GetMoodsByArtistQueryValidator : AbstractValidator<GetMoodsByArtistQuery>
{
    public GetMoodsByArtistQueryValidator()
    {
        RuleFor(x => x.ArtistId)
            .NotEmpty().WithMessage("ID is required.")
            .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
    }
}
