using AutoMapper;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Medias.Commands.UpdateMedia;

public class UpdateMediaCommandHandler : IRequestHandler<UpdateMediaCommand, UpdateMediaCommandResponse>
{
    private readonly IMapper _mapper;
    private readonly IBaseRepository<Media> _mediaRepository;

    public UpdateMediaCommandHandler(IMapper mapper, IBaseRepository<Media> mediaRepository)
    {
        _mapper = mapper;
        _mediaRepository = mediaRepository;
    }

    public async Task<UpdateMediaCommandResponse> Handle(UpdateMediaCommand request, CancellationToken cancellationToken)
    {
        var media = await _mediaRepository.GetByBusinessIdAsync(request.Id);

        if (media == null)
        {
            return new UpdateMediaCommandResponse { Success = false, Message = "Media wasn't found :(" };
        }

        _mapper.Map(request, media);

        await _mediaRepository.UpdateAsync(media);

        var updatedMediaDto = _mapper.Map<UpdateMediaDto>(media);

        return new UpdateMediaCommandResponse
        {
            Success = true,
            Message = "Media was Updated :)",
            UpdatedMedia = updatedMediaDto
        };
    }

}
