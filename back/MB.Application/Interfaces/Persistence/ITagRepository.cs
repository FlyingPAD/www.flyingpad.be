using MB.Application.Features.Tags.Queries.GetTagsByMood;
using MB.Application.Features.Tags.Queries.GetTagsCheckBoxesByMood;
using MB.Application.Features.Tags.Queries.GetTagsFullListQuery;
using MB.Domain.TagAggregate;

namespace MB.Application.Interfaces.Persistence;

public interface ITagRepository : IBaseRepository<Tag>
{
    Task<IEnumerable<GetTagsFullListQueryDto>> GetTagsFullListAsync();
    Task<IEnumerable<GetTagsByMoodQueryDto>> GetTagsByMood(int? moodId);
    Task<IEnumerable<GetTagsCheckBoxesByMoodQueryDto>> GetTagsCheckBoxesByMood(int? moodId);
    Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> tagIds);
    Task<Tag?> GetByName(string name);
    Task<List<Tag>> GetByCategory(int categoryId);
    Task<Guid> GetTagCategoryBusinessId(int tagCategoryId);
}