using FluentValidation;

namespace MB.Application.Features.Moods.Queries.GetMoodsByFranchise;

public class GetMoodsByFranchiseQueryValidator : AbstractValidator<GetMoodsByFranchiseQuery>
{
    public GetMoodsByFranchiseQueryValidator()
    {
        RuleFor(x => x.FranchiseId)
            .NotEmpty().WithMessage("ID is required.")
            .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
    }
}
