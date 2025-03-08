using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Domain.UserAggregate;
using MediatR;

namespace MB.Application.Features.Users.Commands.DeleteUser;

public class DeleteUserCommandHandler(IBaseRepository<User> userRepository) : IRequestHandler<DeleteUserCommand, DeleteUserCommandResponse>
{
    private readonly IBaseRepository<User> _userRepository = userRepository;

    public async Task<DeleteUserCommandResponse> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByBusinessIdAsync(request.Id) ?? throw new NotFoundException($"User with ID {request.Id} was not found.");

        await _userRepository.DeleteAsync(user);

        return new DeleteUserCommandResponse
        {
            Success = true,
            Message = "Success."
        };
    }
}