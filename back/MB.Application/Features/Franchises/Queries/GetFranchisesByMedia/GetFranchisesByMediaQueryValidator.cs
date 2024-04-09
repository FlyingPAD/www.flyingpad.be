using FluentValidation;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesByMedia
{
    public class GetFranchisesByMediaQueryValidator : AbstractValidator<GetFranchisesByMediaQuery>
    {
        public GetFranchisesByMediaQueryValidator()
        {
            RuleFor(x => x.MediaId)
                .NotEmpty().WithMessage("ID is required.")
                .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
        }
    }
}