using AutoMapper;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Users.Commands.UpdateUser;

public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, UpdateUserCommandResponse>
{
    private readonly IMapper _mapper;
    private readonly IBaseRepository<User> _userRepository;

    public UpdateUserCommandHandler(IMapper mapper, IBaseRepository<User> userRepository)
    {
        _mapper = mapper;
        _userRepository = userRepository;
    }

    public async Task<UpdateUserCommandResponse> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByBusinessIdAsync(request.BusinessId);

        if (user == null)
        {
            return new UpdateUserCommandResponse { Success = false, Message = "User wasn't found :(" };
        }

        _mapper.Map(request, user);

        await _userRepository.UpdateAsync(user);

        var updatedUserDto = _mapper.Map<UpdateUserDto>(user);

        return new UpdateUserCommandResponse
        {
            Success = true,
            Message = "User was Updated :)",
            UpdatedUser = updatedUserDto
        };
    }

}
