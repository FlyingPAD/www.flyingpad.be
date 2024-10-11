using FluentValidation;

namespace MB.Application.Features.Moods.Queries.GetMoodsByFranchise;

public class GetMoodsByFranchiseQueryValidator : AbstractValidator<GetMoodsByFranchiseQuery>
{
    public GetMoodsByFranchiseQueryValidator()
    {
        RuleFor(request => request.FranchiseId)
            .NotEmpty().WithMessage("FranchiseId is required.")
            .NotEqual(Guid.Empty).WithMessage("FranchiseId must not be empty.");
    }
}