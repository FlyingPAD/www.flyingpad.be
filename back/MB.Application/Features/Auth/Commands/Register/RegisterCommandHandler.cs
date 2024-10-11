using MB.Application.Interfaces;
using MB.Application.Interfaces.Persistence;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Auth.Commands.Register;

public class RegisterCommandHandler(IAuthRepository authRepository, ITokenManager tokenManager) : IRequestHandler<RegisterCommand, RegisterCommandResponse>
{
    private readonly IAuthRepository _authRepository = authRepository;
    private readonly ITokenManager _tokenManager = tokenManager;

    public async Task<RegisterCommandResponse> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        if (await _authRepository.UserExists(request.Email))
        {
            return new RegisterCommandResponse(null)
            {
                Success = false,
                Message = "Email already exists."
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
            Message = "Your account was created."
        };
    }
}