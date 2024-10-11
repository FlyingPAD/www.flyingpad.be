using FluentValidation;

namespace MB.Application.Features.Links.Queries.GetLinkById;

public class GetLinkByIdQueryValidator : AbstractValidator<GetLinkByIdQuery>
{
    public GetLinkByIdQueryValidator()
    {
        RuleFor(request => request.LinkId)
            .NotEmpty().WithMessage("LinkId is required.")
            .NotEqual(Guid.Empty).WithMessage("LinkId must not be empty.");
    }
}