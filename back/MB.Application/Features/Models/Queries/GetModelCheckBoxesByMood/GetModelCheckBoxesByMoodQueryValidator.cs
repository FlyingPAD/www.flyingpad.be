using FluentValidation;

namespace MB.Application.Features.Models.Queries.GetModelCheckBoxesByMood;

public class GetModelCheckBoxesByMoodQueryValidator : AbstractValidator<GetModelCheckBoxesByMoodQuery>
{
    public GetModelCheckBoxesByMoodQueryValidator()
    {
        RuleFor(request => request.MoodId)
            .NotEmpty().WithMessage("MoodId is required.")
            .NotEqual(Guid.Empty).WithMessage("MoodId must not be empty.");
    }
}