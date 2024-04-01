using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Users.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreateUserCommandResponse>
    {
        private readonly IBaseRepository<User> _userRepository;
        private readonly IMapper _mapper;

        public CreateUserCommandHandler(IMapper mapper, IBaseRepository<User> userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var createUserCommandResponse = new CreateUserCommandResponse();

            var validator = new CreateUserCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createUserCommandResponse.Success = false;
                createUserCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createUserCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (createUserCommandResponse.Success)
            {
                var user = new User() { FirstName = request.FirstName, LastName = request.LastName };
                user = await _userRepository.CreateAsync(user);
                createUserCommandResponse.User = _mapper.Map<CreateUserDto>(user);
            }

            return createUserCommandResponse;
        }
    }
}
