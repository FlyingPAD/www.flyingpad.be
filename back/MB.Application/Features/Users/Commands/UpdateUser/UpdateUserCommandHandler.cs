using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Domain.UserAggregate;
using MediatR;

namespace MB.Application.Features.Users.Commands.UpdateUser;

public class UpdateUserCommandHandler(IMapper mapper, IBaseRepository<User> userRepository) : IRequestHandler<UpdateUserCommand, UpdateUserCommandResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<User> _userRepository = userRepository;

    public async Task<UpdateUserCommandResponse> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByBusinessIdAsync(request.BusinessId)
            ?? throw new NotFoundException("User not found.");

        user.UserName = request.UserName;
        user.FirstName = request.FirstName;
        user.LastName = request.LastName;
        user.Birthdate = request.Birthdate;

        await _userRepository.UpdateAsync(user);

        return new UpdateUserCommandResponse
        {
            Success = true,
            Message = "User Updated",
            UpdatedUser = _mapper.Map<UpdateUserCommandDto>(user)
        };
    }
}