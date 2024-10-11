using FluentValidation;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesByMedium;

public class GetFranchisesByMediumQueryValidator : AbstractValidator<GetFranchisesByMediumQuery>
{
    public GetFranchisesByMediumQueryValidator()
    {
        RuleFor(request => request.MediumId)
            .NotEmpty().WithMessage("MediumId is required.")
            .NotEqual(Guid.Empty).WithMessage("MediumId must not be empty.");
    }
}