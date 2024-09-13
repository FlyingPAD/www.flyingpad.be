using FluentValidation;

namespace MB.Application.Features.Tags.Queries.GetTagsCheckBoxesByMood;

public class GetTagsCheckBoxesByMoodQueryValidator : AbstractValidator<GetTagsCheckBoxesByMoodQuery>
{
    public GetTagsCheckBoxesByMoodQueryValidator()
    {
        RuleFor(request => request.MoodId)
            .NotEmpty().WithMessage("MoodId is required.")
            .NotEqual(Guid.Empty).WithMessage("MoodId must not be empty.");
    }
}