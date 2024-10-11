using FluentValidation;

namespace MB.Application.Features.Moods.Queries.GetMoodsByModel;

public class GetMoodsByModelQueryValidator : AbstractValidator<GetMoodsByModelQuery>
{
    public GetMoodsByModelQueryValidator()
    {
        RuleFor(request => request.ModelId)
            .NotEmpty().WithMessage("ModelId is required.")
            .NotEqual(Guid.Empty).WithMessage("ModelId must not be empty.");
    }
}