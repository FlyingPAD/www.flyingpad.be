using AutoMapper;
using MB.Application.Interfaces.Persistence;
using MB.Domain.TagAggregate;
using MediatR;

namespace MB.Application.Features.Tags.Queries.GetAllTags;

public class GetAllTagsQueryHandler(IBaseRepository<Tag> tagRepository, IMapper mapper) : IRequestHandler<GetAllTagsQuery, GetAllTagsQueryResponse>
{
    private readonly IBaseRepository<Tag> _tagRepository = tagRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<GetAllTagsQueryResponse> Handle(GetAllTagsQuery request, CancellationToken cancellationToken)
    {
        var tags = await _tagRepository.GetAllAsync(tag => tag.Name);

        return new GetAllTagsQueryResponse
        {
            Success = true,
            Message = "All tags.",
            Tags = _mapper.Map<List<GetAllTagsQueryDto>>(tags)
        };
    }
}