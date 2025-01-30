using FluentValidation;

namespace MB.Application.Features.Users.Commands.UpdateUser;

public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
{
    public UpdateUserCommandValidator()
    {
        RuleFor(request => request.FirstName).NotEmpty().WithMessage("First Name is required.");
    }
}