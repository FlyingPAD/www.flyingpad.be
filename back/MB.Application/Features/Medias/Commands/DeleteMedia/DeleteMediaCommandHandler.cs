using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Medias.Commands.DeleteMedia;

public class DeleteMediaCommandHandler(IBaseRepository<Media> mediaRepository) : IRequestHandler<DeleteMediaCommand, DeleteMediaCommandResponse>
{
    private readonly IBaseRepository<Media> _mediaRepository = mediaRepository;

    public async Task<DeleteMediaCommandResponse> Handle(DeleteMediaCommand request, CancellationToken cancellationToken)
    {
        var media = await _mediaRepository.GetByBusinessIdAsync(request.MediaId) ?? throw new NotFoundException($"Media with ID {request.MediaId} was not found.");

        await _mediaRepository.DeleteAsync(media);

        return new DeleteMediaCommandResponse
        {
            Success = true,
            Message = "Success."
        };
    }
}