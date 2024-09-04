using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Medias.Commands.CreateMedia;

public class CreateMediaCommandHandler(IBaseRepository<Media> mediaRepository) : IRequestHandler<CreateMediaCommand, CreateMediaCommandResponse>
{
    private readonly IBaseRepository<Media> _mediaRepository = mediaRepository;

    public async Task<CreateMediaCommandResponse> Handle(CreateMediaCommand request, CancellationToken cancellationToken)
    {
        var media = new Media
        {
            Name = request.Name,
            Description = request.Description,
        };

        media = await _mediaRepository.CreateAsync(media);

        return new CreateMediaCommandResponse
        {
            Success = true,
            Message = "Success.",
            MediaId = media.BusinessId
        };
    }
}