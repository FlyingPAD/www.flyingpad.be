using FluentValidation;

namespace MB.Application.Features.LinkCategories.Queries.GetLinkCategoriesCheckBoxesByLink
{
    public class GetLinkCategoriesCheckBoxesByLinkQueryValidator : AbstractValidator<GetLinkCategoriesCheckBoxesByLinkQuery>
    {
        public GetLinkCategoriesCheckBoxesByLinkQueryValidator()
        {
            RuleFor(request => request.LinkId)
                .NotEmpty().WithMessage("LinkId is required.")
                .NotEqual(Guid.Empty).WithMessage("LinkId must not be empty.");
        }
    }
}