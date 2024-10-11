using FluentValidation;

namespace MB.Application.Features.Moods.Queries.GetMoodsByArtist;

public class GetMoodsByArtistQueryValidator : AbstractValidator<GetMoodsByArtistQuery>
{
    public GetMoodsByArtistQueryValidator()
    {
        RuleFor(request => request.ArtistId)
            .NotEmpty().WithMessage("ArtistId is required.")
            .NotEqual(Guid.Empty).WithMessage("ArtistId must not be empty.");
    }
}