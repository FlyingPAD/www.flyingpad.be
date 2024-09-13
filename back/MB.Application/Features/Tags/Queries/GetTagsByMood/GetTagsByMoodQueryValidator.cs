using FluentValidation;

namespace MB.Application.Features.Tags.Queries.GetTagsByMood;

public class GetTagsByMoodQueryValidator : AbstractValidator<GetTagsByMoodQuery>
{
    public GetTagsByMoodQueryValidator()
    {
        RuleFor(request => request.MoodId)
            .NotEmpty().WithMessage("MoodId is required.")
            .NotEqual(Guid.Empty).WithMessage("MoodId must not be empty.");
    }
}