using FluentValidation;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesByMood
{
    public class GetFranchisesByMoodQueryValidator : AbstractValidator<GetFranchisesByMoodQuery>
    {
        public GetFranchisesByMoodQueryValidator()
        {
            RuleFor(x => x.BusinessId)
                .NotEmpty().WithMessage("ID is required.")
                .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
        }
    }
}