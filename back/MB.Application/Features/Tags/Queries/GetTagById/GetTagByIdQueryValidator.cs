using FluentValidation;

namespace MB.Application.Features.Tags.Queries.GetTagById
{
    public class GetTagByIdQueryValidator : AbstractValidator<GetTagByIdQuery>
    {
        public GetTagByIdQueryValidator()
        {
            RuleFor(x => x.TagId)
                .NotEmpty().WithMessage("ID is required.")
                .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
        }
    }
}
