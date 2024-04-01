using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Medias.Commands.CreateMedia
{
    public class CreateMediaCommandHandler : IRequestHandler<CreateMediaCommand, CreateMediaCommandResponse>
    {
        private readonly IBaseRepository<Media> _mediaRepository;
        private readonly IMapper _mapper;

        public CreateMediaCommandHandler(IMapper mapper, IBaseRepository<Media> mediaRepository)
        {
            _mapper = mapper;
            _mediaRepository = mediaRepository;
        }

        public async Task<CreateMediaCommandResponse> Handle(CreateMediaCommand request, CancellationToken cancellationToken)
        {
            var createMediaCommandResponse = new CreateMediaCommandResponse();

            var validator = new CreateMediaCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createMediaCommandResponse.Success = false;
                createMediaCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createMediaCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (createMediaCommandResponse.Success)
            {
                var media = new Media() { Name = request.Name };
                media = await _mediaRepository.CreateAsync(media);
                createMediaCommandResponse.Media = _mapper.Map<CreateMediaDto>(media);
            }

            return createMediaCommandResponse;
        }
    }
}
