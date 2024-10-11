using FluentValidation;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesByMood;

public class GetFranchisesByMoodQueryValidator : AbstractValidator<GetFranchisesByMoodQuery>
{
    public GetFranchisesByMoodQueryValidator()
    {
        RuleFor(request => request.MoodId)
            .NotEmpty().WithMessage("MoodId is required.")
            .NotEqual(Guid.Empty).WithMessage("MoodId must not be empty.");
    }
}