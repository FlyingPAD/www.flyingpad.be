using FluentValidation;

namespace MB.Application.Features.Medias.Queries.GetMediaCheckBoxesByFranchise
{
    public class GetMediaCheckBoxesByFranchiseQueryValidator : AbstractValidator<GetMediaCheckBoxesByFranchiseQuery>
    {
        public GetMediaCheckBoxesByFranchiseQueryValidator()
        {
            RuleFor(request => request.FranchiseId)
                .NotEmpty().WithMessage("FranchiseId is required.")
                .NotEqual(Guid.Empty).WithMessage("FranchiseId must not be empty.");
        }
    }
}