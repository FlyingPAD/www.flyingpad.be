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
        // 1) Récupérer l'utilisateur par BusinessId (GUID)
        var user = await _userRepository
            .GetByBusinessIdAsync(request.BusinessId)
            ?? throw new NotFoundException("User not found.");

        // 2) Appliquer la mise à jour via la méthode métier
        user.UpdateProfile(
            userName: request.UserName,
            firstName: request.FirstName,
            lastName: request.LastName,
            birthdate: request.Birthdate
        );

        // 3) Persister
        await _userRepository.UpdateAsync(user);

        // 4) Retourner le DTO mis à jour
        return new UpdateUserCommandResponse
        {
            Success = true,
            Message = "User updated successfully.",
            UpdatedUser = _mapper.Map<UpdateUserCommandDto>(user)
        };
    }
}