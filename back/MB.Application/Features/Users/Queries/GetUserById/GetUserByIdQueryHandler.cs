using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Users.Queries.GetUserById;

public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, GetUserByIdQueryResponse>
{
    private readonly IMapper _mapper;
    private IBaseRepository<User> _userRepository;

    public GetUserByIdQueryHandler(IMapper mapper, IBaseRepository<User> userRepository)
    {
        _mapper = mapper;
        _userRepository = userRepository;
    }

    public async Task<GetUserByIdQueryResponse> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByBusinessIdAsync(request.Id);

        if (user == null)
        {
            return new GetUserByIdQueryResponse { Success = false, Message = "User wasn't found :(" };
        }

        var userDto = _mapper.Map<GetUserByIdVm>(user);

        return new GetUserByIdQueryResponse
        {
            Success = true,
            Message = "User was found :)",
            User = userDto
        };
    }
}
