using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Styles.Commands.CreateStyle
{
    public class CreateStyleCommandHandler : IRequestHandler<CreateStyleCommand, CreateStyleCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBaseRepository<Style> _styleRepository;
        private readonly CreateStyleCommandValidator _validator;

        public CreateStyleCommandHandler(IMapper mapper, IBaseRepository<Style> styleRepository, CreateStyleCommandValidator validator)
        {
            _mapper = mapper;
            _styleRepository = styleRepository;
            _validator = validator;
        }

        public async Task<CreateStyleCommandResponse> Handle(CreateStyleCommand request, CancellationToken cancellationToken)
        {
            // Validation

            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count > 0)
            {
                return new CreateStyleCommandResponse
                {
                    Message = "Error(s)...",
                    ValidationErrors = validationResult.Errors.Select(error => error.ErrorMessage).ToList()
                };
            }

            // Success

            var style = new Style { Name = request.Name };

            style = await _styleRepository.CreateAsync(style);

            return new CreateStyleCommandResponse
            {
                Success = true,
                Message = $"The style '{style.Name}' has been successfully created.",
                Style = _mapper.Map<CreateStyleDto>(style)
            };
        }
    }
}