using MB.Application.Interfaces.Persistence;
using MB.Domain.UserAggregate;
using MediatR;

namespace MB.Application.Features.Users.Commands.CreateUser;

public class CreateUserCommandHandler(IBaseRepository<User> userRepository) : IRequestHandler<CreateUserCommand, CreateUserCommandResponse>
{
    private readonly IBaseRepository<User> _userRepository = userRepository;

    public async Task<CreateUserCommandResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = new User
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
        };

        user = await _userRepository.CreateAsync(user);

        return new CreateUserCommandResponse
        {
            Success = true,
            Message = "Success.",
            BusinessId = user.BusinessId
        };
    }
}