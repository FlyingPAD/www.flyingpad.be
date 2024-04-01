using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Users.Queries.GetUsersList
{
    public class GetUsersListQueryHandler : IRequestHandler<GetUsersListQuery, GetUsersListQueryResponse>
    {
        private readonly IBaseRepository<User> _userRepository;
        private readonly IMapper _mapper;

        public GetUsersListQueryHandler(IBaseRepository<User> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<GetUsersListQueryResponse> Handle(GetUsersListQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var users = await _userRepository.GetAllAsync();
                var response = new GetUsersListQueryResponse
                {
                    Success = true,
                    Message = "Here are the Users !",
                    UsersList = _mapper.Map<List<UserListVm>>(users)
                };

                return response;
            }
            catch (Exception ex)
            {
                // Gérez l'exception et renvoyez une réponse d'erreur
                var response = new GetUsersListQueryResponse
                {
                    Success = false,
                    ValidationErrors = new List<string> { $"Une erreur s'est produite ( {ex} )." }
                };

                return response;
            }
        }
    }
}
