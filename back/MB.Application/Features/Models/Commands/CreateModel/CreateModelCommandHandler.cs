using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Models.Commands.CreateModel
{
    public class CreateModelCommandHandler : IRequestHandler<CreateModelCommand, CreateModelCommandResponse>
    {
        private readonly IBaseRepository<Model> _modelRepository;
        private readonly IMapper _mapper;

        public CreateModelCommandHandler(IMapper mapper, IBaseRepository<Model> modelRepository)
        {
            _mapper = mapper;
            _modelRepository = modelRepository;
        }

        public async Task<CreateModelCommandResponse> Handle(CreateModelCommand request, CancellationToken cancellationToken)
        {
            var createModelCommandResponse = new CreateModelCommandResponse();

            var validator = new CreateModelCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createModelCommandResponse.Success = false;
                createModelCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createModelCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (createModelCommandResponse.Success)
            {
                var model = new Model() { FirstName = request.FirstName, LastName = request.LastName };
                model = await _modelRepository.CreateAsync(model);
                createModelCommandResponse.Model = _mapper.Map<CreateModelDto>(model);
            }

            return createModelCommandResponse;
        }
    }
}
