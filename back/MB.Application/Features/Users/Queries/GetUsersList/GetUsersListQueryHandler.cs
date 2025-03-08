using AutoMapper;
using MB.Application.Interfaces.Persistence;
using MB.Domain.UserAggregate;
using MediatR;

namespace MB.Application.Features.Users.Queries.GetUsersList;

public class GetUsersListQueryHandler(IBaseRepository<User> userRepository, IMapper mapper) : IRequestHandler<GetUsersListQuery, GetUsersListQueryResponse>
{
    private readonly IBaseRepository<User> _userRepository = userRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<GetUsersListQueryResponse> Handle(GetUsersListQuery request, CancellationToken cancellationToken)
    {
        var users = await _userRepository.GetAllAsync();

        var response = new GetUsersListQueryResponse
        {
            Success = true,
            Message = "Success.",
            UsersList = _mapper.Map<List<GetUsersListQueryDto>>(users)
        };

        return response;
    }
}