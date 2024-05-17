using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Users.Commands.DeleteUser;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Task.Commands.DeleteTask;

public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, DeleteUserCommandResponse>
{
    private readonly IMapper _mapper;
    private readonly IBaseRepository<User> _userRepository;

    public DeleteUserCommandHandler(IMapper mapper, IBaseRepository<User> userRepository)
    {
        _mapper = mapper;
        _userRepository = userRepository;
    }

    public async Task<DeleteUserCommandResponse> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        var deleteUserCommandResponse = new DeleteUserCommandResponse();

        var validator = new DeleteUserCommandValidator();
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.Errors.Count > 0)
        {
            deleteUserCommandResponse.Success = false;
            deleteUserCommandResponse.ValidationErrors = new List<string>();
            foreach (var error in validationResult.Errors)
            {
                deleteUserCommandResponse.ValidationErrors.Add(error.ErrorMessage);
            }
        }
        if (deleteUserCommandResponse.Success)
        {
            var user = await _userRepository.GetByBusinessIdAsync(request.Id);
            if (user != null)
            {
                await _userRepository.DeleteAsync(user);
                deleteUserCommandResponse.Success = true;
            }
            else
            {
                deleteUserCommandResponse.Success = false;
                deleteUserCommandResponse.ValidationErrors = new List<string>
                {
                    "Selected user doesn't exist."
                };
            }
        }

        return deleteUserCommandResponse;
    }
}
