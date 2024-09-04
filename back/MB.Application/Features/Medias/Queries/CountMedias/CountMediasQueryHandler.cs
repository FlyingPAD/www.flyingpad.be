using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Medias.Queries.CountMedias;

public class CountMediasQueryHandler : IRequestHandler<CountMediasQuery, CountMediasQueryResponse>
{
    private readonly IBaseRepository<Media> _mediaRepository;

    public CountMediasQueryHandler(IBaseRepository<Media> mediaRepository)
    {
        _mediaRepository = mediaRepository;
    }

    public async Task<CountMediasQueryResponse> Handle(CountMediasQuery request, CancellationToken cancellationToken)
    {
        var mediasCount = await _mediaRepository.CountAsync();

        return new CountMediasQueryResponse
        {
            Success = true,
            Message = $"Total Medias : {mediasCount}",
            MediasCount = mediasCount
        };
    }
}
