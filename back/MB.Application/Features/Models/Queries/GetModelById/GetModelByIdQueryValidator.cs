using FluentValidation;

namespace MB.Application.Features.Models.Queries.GetModelById
{
    public class GetModelByIdQueryValidator : AbstractValidator<GetModelByIdQuery>
    {
        public GetModelByIdQueryValidator()
        {
            RuleFor(x => x.ModelId)
                .NotEmpty().WithMessage("ID is required.")
                .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
        }
    }
}
