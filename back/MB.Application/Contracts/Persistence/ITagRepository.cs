using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Tags.Queries.GetTagsByMood;
using MB.Application.Features.Tags.Queries.GetTagsFullListQuery;
using MB.Domain.Entities;

namespace MB.Application.Contracts.Persistence
{
    public interface ITagRepository : IBaseRepository<Tag>
    {
        Task<IEnumerable<GetTagsFullListQueryVm>> GetTagsFullListAsync();
        Task<IEnumerable<GetTagsByMoodQueryVm>> GetTagsByMood( int? entityId );
    }
}