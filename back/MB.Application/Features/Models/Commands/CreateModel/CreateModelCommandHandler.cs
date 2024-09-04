using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Models.Commands.CreateModel;

public class CreateModelCommandHandler(IBaseRepository<Model> modelRepository) : IRequestHandler<CreateModelCommand, CreateModelCommandResponse>
{
    private readonly IBaseRepository<Model> _modelRepository = modelRepository;

    public async Task<CreateModelCommandResponse> Handle(CreateModelCommand request, CancellationToken cancellationToken)
    {
        var model = new Model
        {
            Pseudonym = request.Pseudonym,
            FirstName = request.FirstName,
            LastName = request.LastName,
            Gender = request.Gender,
            Description = request.Description,
        };

        model = await _modelRepository.CreateAsync(model);

        return new CreateModelCommandResponse
        {
            Success = true,
            Message = "Success.",
            ModelId = model.BusinessId
        };
    }
}