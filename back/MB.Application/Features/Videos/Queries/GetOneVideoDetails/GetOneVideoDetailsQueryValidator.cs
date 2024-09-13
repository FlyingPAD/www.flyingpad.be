using FluentValidation;

namespace MB.Application.Features.Videos.Queries.GetOneVideoDetails;

public class GetOneVideoDetailsQueryValidator : AbstractValidator<GetOneVideoDetailsQuery>
{
    public GetOneVideoDetailsQueryValidator()
    {
        RuleFor(request => request.VideoId)
            .NotEmpty().WithMessage("VideoId is required.")
            .NotEqual(Guid.Empty).WithMessage("VideoId must not be empty.");
    }
}