using FluentValidation;

namespace MB.Application.Features.Models.Queries.GetModelsByMood;

public class GetModelsByMoodQueryValidator : AbstractValidator<GetModelsByMoodQuery>
{
    public GetModelsByMoodQueryValidator()
    {
        RuleFor(request => request.MoodId)
        .NotEmpty().WithMessage("MoodId is required.")
        .NotEqual(Guid.Empty).WithMessage("MoodId must not be empty.");
    }
}