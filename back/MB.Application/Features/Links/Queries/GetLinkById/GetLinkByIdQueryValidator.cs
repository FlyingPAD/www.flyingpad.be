using FluentValidation;

namespace MB.Application.Features.Links.Queries.GetLinkById;

public class GetLinkByIdQueryValidator : AbstractValidator<GetLinkByIdQuery>
{
    public GetLinkByIdQueryValidator()
    {
        RuleFor(x => x.LinkId)
            .NotEmpty().WithMessage("ID is required.")
            .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
    }
}