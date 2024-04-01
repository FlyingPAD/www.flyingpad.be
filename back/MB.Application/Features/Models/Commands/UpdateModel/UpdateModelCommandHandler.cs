using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Models.Commands.UpdateModel
{
    public class UpdateModelCommandHandler : IRequestHandler<UpdateModelCommand, UpdateModelCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBaseRepository<Model> _modelRepository;

        public UpdateModelCommandHandler(IMapper mapper, IBaseRepository<Model> modelRepository)
        {
            _mapper = mapper;
            _modelRepository = modelRepository;
        }

        public async Task<UpdateModelCommandResponse> Handle(UpdateModelCommand request, CancellationToken cancellationToken)
        {
            var model = await _modelRepository.GetByBusinessIdAsync(request.Id);

            if (model == null)
            {
                return new UpdateModelCommandResponse { Success = false, Message = "Model wasn't found :(" };
            }

            _mapper.Map(request, model);

            await _modelRepository.UpdateAsync(model);

            var updatedModelDto = _mapper.Map<UpdateModelDto>(model);

            return new UpdateModelCommandResponse
            {
                Success = true,
                Message = "Model was Updated :)",
                UpdatedModel = updatedModelDto
            };
        }

    }
}
