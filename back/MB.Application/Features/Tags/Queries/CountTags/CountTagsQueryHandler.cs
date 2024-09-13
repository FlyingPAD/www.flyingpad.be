using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Tags.Queries.CountTags;

public class CountTagsQueryHandler(IBaseRepository<Tag> tagRepository) : IRequestHandler<CountTagsQuery, CountTagsQueryResponse>
{
    private readonly IBaseRepository<Tag> _tagRepository = tagRepository;

    public async Task<CountTagsQueryResponse> Handle(CountTagsQuery request, CancellationToken cancellationToken)
    {
        var tagsCount = await _tagRepository.CountAsync();

        return new CountTagsQueryResponse
        {
            Success = true,
            Message = $"Total Tags : {tagsCount}",
            TagsCount = tagsCount
        };
    }
}