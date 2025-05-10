using AutoMapper;
using MB.Application.Features.Users.Queries.GetAllUsers;
using MB.Application.Interfaces.Persistence;
using MediatR;

public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, GetAllUsersQueryResponse>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public GetAllUsersQueryHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<GetAllUsersQueryResponse> Handle(
        GetAllUsersQuery request,
        CancellationToken cancellationToken)
    {
        // Charge désormais les achievements
        var users = await _userRepository.GetAllWithAchievementsAsync();

        var response = new GetAllUsersQueryResponse
        {
            Success = true,
            Message = "Success.",
            Users = _mapper.Map<List<GetAllUsersQueryDto>>(users)
        };

        return response;
    }
}