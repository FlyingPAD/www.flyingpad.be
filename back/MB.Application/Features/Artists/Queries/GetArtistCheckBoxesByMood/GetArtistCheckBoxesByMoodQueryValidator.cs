using FluentValidation;

namespace MB.Application.Features.Artists.Queries.GetArtistCheckBoxesByMood;

public class GetArtistCheckBoxesByMoodQueryValidator : AbstractValidator<GetArtistCheckBoxesByMoodQuery>
{
    public GetArtistCheckBoxesByMoodQueryValidator()
    {
        RuleFor(request => request.MoodId)
            .NotEmpty().WithMessage("MoodId is required.")
            .NotEqual(Guid.Empty).WithMessage("MoodId must not be empty.");
    }
}