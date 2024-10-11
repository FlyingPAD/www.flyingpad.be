using FluentValidation;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesCheckBoxesByModel
{
    public class GetFranchisesCheckBoxesByModelQueryValidator : AbstractValidator<GetFranchisesCheckBoxesByModelQuery>
    {
        public GetFranchisesCheckBoxesByModelQueryValidator()
        {
            RuleFor(request => request.ModelId)
                .NotEmpty().WithMessage("ModelId is required.")
                .NotEqual(Guid.Empty).WithMessage("ModelId must not be empty.");
        }
    }
}