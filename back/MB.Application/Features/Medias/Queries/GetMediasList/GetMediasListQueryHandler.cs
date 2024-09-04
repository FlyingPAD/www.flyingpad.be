using AutoMapper;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Medias.Queries.GetMediasList;

public class GetMediasListQueryHandler(IBaseRepository<Media> mediaRepository, IMapper mapper) : IRequestHandler<GetMediasListQuery, GetMediasListQueryResponse>
{
    private readonly IBaseRepository<Media> _mediaRepository = mediaRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<GetMediasListQueryResponse> Handle(GetMediasListQuery request, CancellationToken cancellationToken)
    {

        var medias = await _mediaRepository.GetAllAsync();
        var response = new GetMediasListQueryResponse
        {
            Success = true,
            Message = "Success.",
            Medias = _mapper.Map<List<MediaListVm>>(medias)
        };

        return response;
    }
}