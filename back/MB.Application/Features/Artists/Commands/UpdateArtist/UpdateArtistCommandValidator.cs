﻿using FluentValidation;

namespace MB.Application.Features.Artists.Commands.UpdateArtist;

public class UpdateArtistCommandValidator : AbstractValidator<UpdateArtistCommand>
{
    public UpdateArtistCommandValidator()
    {
        RuleFor(request => request.BusinessId)
            .NotEmpty().WithMessage("ID is required.")
            .Must(id => id != Guid.Empty).WithMessage("ID must be a valid GUID.");

        RuleFor(request => request.Name)
            .NotEmpty().WithMessage("Name is required.")
            .Length(2, 100).WithMessage("Name must be between 2 and 100 characters.");
    }
}