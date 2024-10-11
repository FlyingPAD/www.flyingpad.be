using AutoMapper;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Medias.Queries.GetAllMedia;

public class GetAllMediaQueryHandler(IBaseRepository<Media> mediaRepository, IMapper mapper) : IRequestHandler<GetAllMediaQuery, GetAllMediaQueryResponse>
{
    private readonly IBaseRepository<Media> _mediaRepository = mediaRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<GetAllMediaQueryResponse> Handle(GetAllMediaQuery request, CancellationToken cancellationToken)
    {
        var medias = await _mediaRepository.GetAllAsync(media => media.Name);

        return new GetAllMediaQueryResponse
        {
            Success = true,
            Message = "All media.",
            Media = _mapper.Map<List<GetAllMediaQueryDto>>(medias)
        };
    }
}