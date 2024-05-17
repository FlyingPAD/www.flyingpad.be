using FluentValidation;

namespace MB.Application.Features.Moods.Queries.GetMoodsByModel;

public class GetMoodsByModelQueryValidator : AbstractValidator<GetMoodsByModelQuery>
{
    public GetMoodsByModelQueryValidator()
    {
        RuleFor(x => x.ModelId)
            .NotEmpty().WithMessage("ID is required.")
            .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
    }
}
