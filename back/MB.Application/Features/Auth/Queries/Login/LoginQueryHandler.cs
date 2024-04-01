using MB.Application.Contracts;
using MB.Application.Contracts.Persistence;
using MediatR;

namespace MB.Application.Features.Auth.Queries.Login
{
    public class LoginQueryHandler(IAuthRepository authRepository, ITokenManager tokenManager, LoginQueryValidator validator) : IRequestHandler<LoginQuery, LoginQueryResponse>
    {
        private readonly IAuthRepository _authRepository = authRepository;
        private readonly ITokenManager _tokenManager = tokenManager;
        private readonly LoginQueryValidator _validator = validator;

        public async Task<LoginQueryResponse> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var response = new LoginQueryResponse(null)
                {
                    Success = false,
                    Message = "Validation failed.",
                    ValidationErrors = validationResult.Errors.Select(e => e.ErrorMessage).ToList()
                };
                return response;
            }

            var user = await _authRepository.LoginAsync(request.Email, request.Password);

            if (user == null) // La vérification du mot de passe est déjà effectuée dans AuthRepository
            {
                return new LoginQueryResponse(null)
                {
                    Success = false,
                    Message = "Invalid credentials."
                };
            }

            var token = _tokenManager.GenerateToken(user);

            return new LoginQueryResponse(token)
            {
                Success = true,
                Message = "Authentication successful."
            };
        }
    }
}
