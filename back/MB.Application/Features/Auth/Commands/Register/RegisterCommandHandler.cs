using MB.Application.Contracts;
using MB.Application.Contracts.Persistence;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Auth.Commands.Register;

public class RegisterCommandHandler(IAuthRepository authRepository, ITokenManager tokenManager, RegisterCommandValidator validator) : IRequestHandler<RegisterCommand, RegisterCommandResponse>
{
    private readonly IAuthRepository _authRepository = authRepository;
    private readonly ITokenManager _tokenManager = tokenManager;
    private readonly RegisterCommandValidator _validator = validator;

    public async Task<RegisterCommandResponse> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
        {
            return new RegisterCommandResponse(null)
            {
                Success = false,
                ValidationErrors = validationResult.Errors.Select(e => e.ErrorMessage).ToList()
            };
        }

        if (await _authRepository.UserExists(request.Email))
        {
            return new RegisterCommandResponse(null)
            {
                Success = false,
                Message = "Un utilisateur avec cet email existe déjà."
            };
        }

        var user = new User
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email
        };

        if(request.Birthdate != null) 
        {
            user.Birthdate = (DateTime)request.Birthdate;
        }

        var registeredUser = await _authRepository.RegisterAsync(user, request.Pass);

        var token = _tokenManager.GenerateToken(registeredUser);

        return new RegisterCommandResponse(token)
        {
            Success = true,
            Message = "Enregistrement réussi."
        };
    }
}