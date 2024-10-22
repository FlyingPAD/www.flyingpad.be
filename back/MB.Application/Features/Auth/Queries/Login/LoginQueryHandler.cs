using MB.Application.Exceptions;
using MB.Application.Interfaces;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Auth.Queries.Login;

public class LoginQueryHandler(IAuthRepository authRepository, ITokenManager tokenManager) : IRequestHandler<LoginQuery, LoginQueryResponse>
{
    private readonly IAuthRepository _authRepository = authRepository;
    private readonly ITokenManager _tokenManager = tokenManager;

    public async Task<LoginQueryResponse> Handle(LoginQuery request, CancellationToken cancellationToken)
    {
        var user = await _authRepository.LoginAsync(request.Email, request.Password)
            ?? throw new NotFoundException("Invalid credentials.");

        var token = _tokenManager.GenerateToken(user);

        return new LoginQueryResponse(token)
        {
            Success = true,
            Message = "Login successful."
        };
    }
}