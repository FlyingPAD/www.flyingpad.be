using FluentValidation;

namespace MB.Application.Features.Franchises.Queries.GetFranchiseById;

public class GetFranchiseByIdQueryValidator : AbstractValidator<GetFranchiseByIdQuery>
{
    public GetFranchiseByIdQueryValidator()
    {
        RuleFor(request => request.FranchiseId)
            .NotEmpty().WithMessage("FranchiseId is required.")
            .NotEqual(Guid.Empty).WithMessage("FranchiseId must not be empty.");
    }
}