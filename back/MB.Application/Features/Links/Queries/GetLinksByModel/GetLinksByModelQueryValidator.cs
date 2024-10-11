using FluentValidation;

namespace MB.Application.Features.Links.Queries.GetLinksByModel
{
    public class GetLinksByModelQueryValidator : AbstractValidator<GetLinksByModelQuery>
    { 
        public GetLinksByModelQueryValidator()
        {
            RuleFor(request => request.ModelId)
                .NotEmpty().WithMessage("ModelId is required.")
                .NotEqual(Guid.Empty).WithMessage("ModelId must not be empty.");
        }
    }
}