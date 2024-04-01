using FluentValidation;

namespace MB.Application.Features.Styles.Queries.GetStyleById
{
    public class GetStyleByIdQueryValidator : AbstractValidator<GetStyleByIdQuery>
    {
        public GetStyleByIdQueryValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("ID is required.")
                .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
        }
    }
}
