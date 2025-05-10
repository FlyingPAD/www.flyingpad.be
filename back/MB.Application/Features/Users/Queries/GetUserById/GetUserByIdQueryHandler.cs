using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Users.Queries.GetUserById;

public class GetUserByIdQueryHandler(IMapper mapper, IUserRepository userRepository) : IRequestHandler<GetUserByIdQuery, GetUserByIdQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IUserRepository _userRepository = userRepository;

    public async Task<GetUserByIdQueryResponse> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByBusinessIdFullAsync(request.UserId) ?? throw new NotFoundException("User not found.");

        return new GetUserByIdQueryResponse
        {
            Success = true,
            Message = $"Données de {user.UserName}.",
            User = _mapper.Map<GetUserByIdQueryDto>(user)
        };
    }
}