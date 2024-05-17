using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Medias.Commands.DeleteMedia;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Task.Commands.DeleteTask;

public class DeleteMediaCommandHandler : IRequestHandler<DeleteMediaCommand, DeleteMediaCommandResponse>
{
    private readonly IMapper _mapper;
    private readonly IBaseRepository<Media> _mediaRepository;

    public DeleteMediaCommandHandler(IMapper mapper, IBaseRepository<Media> mediaRepository)
    {
        _mapper = mapper;
        _mediaRepository = mediaRepository;
    }

    public async Task<DeleteMediaCommandResponse> Handle(DeleteMediaCommand request, CancellationToken cancellationToken)
    {
        var deleteMediaCommandResponse = new DeleteMediaCommandResponse();

        var validator = new DeleteMediaCommandValidator();
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.Errors.Count > 0)
        {
            deleteMediaCommandResponse.Success = false;
            deleteMediaCommandResponse.ValidationErrors = new List<string>();
            foreach (var error in validationResult.Errors)
            {
                deleteMediaCommandResponse.ValidationErrors.Add(error.ErrorMessage);
            }
        }
        if (deleteMediaCommandResponse.Success)
        {
            var media = await _mediaRepository.GetByBusinessIdAsync(request.MediaId);
            if (media != null)
            {
                await _mediaRepository.DeleteAsync(media);
                deleteMediaCommandResponse.Success = true;
            }
            else
            {
                deleteMediaCommandResponse.Success = false;
                deleteMediaCommandResponse.ValidationErrors = new List<string>
                {
                    "Selected media doesn't exist."
                };
            }
        }

        return deleteMediaCommandResponse;
    }
}
