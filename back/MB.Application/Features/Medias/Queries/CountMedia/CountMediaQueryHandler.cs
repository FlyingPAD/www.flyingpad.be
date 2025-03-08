using MB.Application.Interfaces.Persistence;
using MB.Domain.MediumAggregate;
using MediatR;

namespace MB.Application.Features.Medias.Queries.CountMedia;

public class CountMediaQueryHandler(IBaseRepository<Media> mediaRepository) : IRequestHandler<CountMediaQuery, CountMediaQueryResponse>
{
    private readonly IBaseRepository<Media> _mediaRepository = mediaRepository;

    public async Task<CountMediaQueryResponse> Handle(CountMediaQuery request, CancellationToken cancellationToken)
    {
        return new CountMediaQueryResponse
        {
            Success = true,
            Message = "Media count completed.",
            TotalMedia = await _mediaRepository.CountAsync()
        };
    }
}