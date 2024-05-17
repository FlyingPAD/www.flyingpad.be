using FluentValidation;

namespace MB.Application.Features.Medias.Queries.GetMediaById;

public class GetMediaByIdQueryValidator : AbstractValidator<GetMediaByIdQuery>
{
    public GetMediaByIdQueryValidator()
    {
        RuleFor(x => x.MediaId)
            .NotEmpty().WithMessage("ID is required.")
            .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
    }
}
