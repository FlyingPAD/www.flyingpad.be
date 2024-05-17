using FluentValidation;

namespace MB.Application.Features.Moods.Queries.GetMoodById;

public class GetMoodByIdQueryValidator : AbstractValidator<GetMoodByIdQuery>
{
    public GetMoodByIdQueryValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("ID is required.")
            .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
    }
}
