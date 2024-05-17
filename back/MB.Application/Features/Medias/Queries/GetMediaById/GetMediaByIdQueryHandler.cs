using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Medias.Queries.GetMediaById;

public class GetMediaByIdQueryHandler : IRequestHandler<GetMediaByIdQuery, GetMediaByIdQueryResponse>
{
    private readonly IMapper _mapper;
    private IBaseRepository<Media> _mediaRepository;

    public GetMediaByIdQueryHandler(IMapper mapper, IBaseRepository<Media> mediaRepository)
    {
        _mapper = mapper;
        _mediaRepository = mediaRepository;
    }

    public async Task<GetMediaByIdQueryResponse> Handle(GetMediaByIdQuery request, CancellationToken cancellationToken)
    {
        var media = await _mediaRepository.GetByBusinessIdAsync(request.MediaId);

        if (media == null)
        {
            return new GetMediaByIdQueryResponse { Success = false, Message = "Media wasn't found :(" };
        }

        var mediaDto = _mapper.Map<GetMediaByIdVm>(media);

        return new GetMediaByIdQueryResponse
        {
            Success = true,
            Message = "Media was found :)",
            Media = mediaDto
        };
    }
}
