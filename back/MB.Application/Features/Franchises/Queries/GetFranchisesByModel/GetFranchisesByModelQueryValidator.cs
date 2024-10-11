using FluentValidation;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesByModel;

public class GetFranchisesByModelQueryValidator : AbstractValidator<GetFranchisesByModelQuery>
{
    public GetFranchisesByModelQueryValidator()
    {
        RuleFor(request => request.ModelId)
            .NotEmpty().WithMessage("ModelId is required.")
            .NotEqual(Guid.Empty).WithMessage("ModelId must not be empty.");
    }
}