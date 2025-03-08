using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Domain.UserAggregate;
using MediatR;

namespace MB.Application.Features.Users.Queries.GetUserById;

public class GetUserByIdQueryHandler(IMapper mapper, IBaseRepository<User> userRepository) : IRequestHandler<GetUserByIdQuery, GetUserByIdQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private IBaseRepository<User> _userRepository = userRepository;

    public async Task<GetUserByIdQueryResponse> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByBusinessIdAsync(request.UserId) 
            ?? throw new NotFoundException("User not found.");

        return new GetUserByIdQueryResponse()
        {
            Success = true,
            Message = $"{user.UserName}.",
            User = _mapper.Map<GetUserByIdQueryDto>(user)
        };
    }
}