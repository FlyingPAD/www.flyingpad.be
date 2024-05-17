using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Tags.Queries.GetTagsByMood;
using MB.Application.Features.Tags.Queries.GetTagsCheckBoxesByMood;
using MB.Application.Features.Tags.Queries.GetTagsFullListQuery;
using MB.Domain.Entities;

namespace MB.Application.Contracts.Persistence;

public interface ITagRepository : IBaseRepository<Tag>
{
    Task<IEnumerable<GetTagsFullListQueryVm>> GetTagsFullListAsync();
    Task<IEnumerable<GetTagsByMoodQueryVm>> GetTagsByMood( int? moodId );
    Task<IEnumerable<GetTagsCheckBoxesListDto>> GetTagsCheckBoxesByMood( int? moodId );
    Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> tagIds);
    Task<Tag?> GetByName(string name);
}