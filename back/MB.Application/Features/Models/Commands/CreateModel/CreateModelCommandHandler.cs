using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Models.Commands.CreateModel;

public class CreateModelCommandHandler(IMapper mapper, IBaseRepository<Model> modelRepository) : IRequestHandler<CreateModelCommand, CreateModelCommandResponse>
{
    private readonly IBaseRepository<Model> _modelRepository = modelRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<CreateModelCommandResponse> Handle(CreateModelCommand request, CancellationToken cancellationToken)
    {
        var createModelCommandResponse = new CreateModelCommandResponse();

        var validator = new CreateModelCommandValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (validationResult.Errors.Count > 0)
        {
            createModelCommandResponse.Success = false;
            createModelCommandResponse.ValidationErrors = [];
            foreach (var error in validationResult.Errors)
            {
                createModelCommandResponse.ValidationErrors.Add(error.ErrorMessage);
            }
            return createModelCommandResponse;
        }

        var model = _mapper.Map<Model>(request);
        model = await _modelRepository.CreateAsync(model);
        createModelCommandResponse.ModelId = model.BusinessId;
        createModelCommandResponse.Success = true;

        return createModelCommandResponse;
    }
}
