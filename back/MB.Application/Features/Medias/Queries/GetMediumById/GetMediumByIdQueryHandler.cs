using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Domain.MediumAggregate;
using MediatR;

namespace MB.Application.Features.Medias.Queries.GetMediumById;

public class GetMediumByIdQueryHandler(IMapper mapper, IBaseRepository<Media> mediaRepository) : IRequestHandler<GetMediumByIdQuery, GetMediumByIdQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Media> _mediaRepository = mediaRepository;

    public async Task<GetMediumByIdQueryResponse> Handle(GetMediumByIdQuery request, CancellationToken cancellationToken)
    {
        var medium = await _mediaRepository.GetByBusinessIdAsync(request.MediumId)
            ?? throw new NotFoundException("Medium not found.");

        return new GetMediumByIdQueryResponse
        {
            Success = true,
            Message = $"{medium.Name}.",
            Medium = _mapper.Map<GetMediumByIdQueryDto>(medium)
        };
    }
}