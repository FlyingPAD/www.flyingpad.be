using FluentValidation;

namespace MB.Application.Features.Links.Queries.GetLinksByCategory;

public class GetLinksContainingAbcQueryValidator : AbstractValidator<GetLinksByCategoryQuery>
{
    public GetLinksContainingAbcQueryValidator()
    {
        RuleFor(request => request.LinkCategoryId)
            .NotEmpty().WithMessage("LinkCategoryId is required.")
            .NotEqual(Guid.Empty).WithMessage("LinkCategoryId must not be empty.");
    }
}