using FluentValidation;

namespace MB.Application.Features.Artists.Queries.GetArtistsByMood;

public class GetArtistsByMoodQueryValidator : AbstractValidator<GetArtistsByMoodQuery>
{
    public GetArtistsByMoodQueryValidator()
    {
        RuleFor(request => request.MoodId)
            .NotEmpty().WithMessage("MoodId is required.")
            .NotEqual(Guid.Empty).WithMessage("MoodId must not be empty.");
    }
}