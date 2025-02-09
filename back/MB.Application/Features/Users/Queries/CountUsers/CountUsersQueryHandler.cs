using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Users.Queries.CountUsers;

public class CountUsersQueryHandler(IBaseRepository<User> userRepository) : IRequestHandler<CountUsersQuery, CountUsersQueryResponse>
{
    private readonly IBaseRepository<User> _userRepository = userRepository;

    public async Task<CountUsersQueryResponse> Handle(CountUsersQuery request, CancellationToken cancellationToken)
    {
        var usersCount = await _userRepository.CountAsync();

        return new CountUsersQueryResponse
        {
            Success = true,
            Message = $"Total Users : {usersCount}",
            UsersCount = usersCount
        };
    }
}