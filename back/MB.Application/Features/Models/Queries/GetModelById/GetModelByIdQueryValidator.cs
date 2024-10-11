using FluentValidation;

namespace MB.Application.Features.Models.Queries.GetModelById;

public class GetModelByIdQueryValidator : AbstractValidator<GetModelByIdQuery>
{
    public GetModelByIdQueryValidator()
    {
        RuleFor(request => request.ModelId)
            .NotEmpty().WithMessage("ModelId is required.")
            .NotEqual(Guid.Empty).WithMessage("ModelId must not be empty.");
    }
}