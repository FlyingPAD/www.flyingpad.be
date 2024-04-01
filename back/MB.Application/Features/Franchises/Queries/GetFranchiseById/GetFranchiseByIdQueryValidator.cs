using FluentValidation;

namespace MB.Application.Features.Franchises.Queries.GetFranchiseById
{
    public class GetFranchiseByIdQueryValidator : AbstractValidator<GetFranchiseByIdQuery>
    {
        public GetFranchiseByIdQueryValidator()
        {
            RuleFor(x => x.BusinessId)
                .NotEmpty().WithMessage("ID is required.")
                .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
        }
    }
}
