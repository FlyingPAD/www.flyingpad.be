using FluentValidation;

namespace MB.Application.Features.Franchises.Commands.UpdateFranchise;

public class UpdateFranchiseCommandValidator : AbstractValidator<UpdateFranchiseCommand>
{
    public UpdateFranchiseCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required.");
    }
}
