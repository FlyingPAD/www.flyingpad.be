using MB.Application.Contracts.Persistence;
using MB.Application.Features.Tags.Queries.GetTagsByMood;
using MB.Application.Features.Tags.Queries.GetTagsCheckBoxesByMood;
using MB.Application.Features.Tags.Queries.GetTagsFullListQuery;
using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories;

public class TagRepository(Context context) : BaseRepository<Tag>(context), ITagRepository
{
    /// <summary>
    /// Retrieves a list of tag entity IDs based on their business IDs.
    /// </summary>
    public async Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds)
    {
        return await _context.Tags
                             .Where(tag => businessIds.Contains(tag.BusinessId))
                             .Select(tag => tag.EntityId)
                             .ToListAsync();
    }

    /// <summary>
    /// Gets tags associated with a specific mood.
    /// </summary>
    public async Task<IEnumerable<GetTagsByMoodQueryVm>> GetTagsByMood(int? moodId)
    {
        return await _context.RMoodTag
            .Where(mt => mt.MoodId == moodId && mt.Tag != null)
            .Select(mt => new GetTagsByMoodQueryVm
            {
                BusinessId = mt.Tag!.BusinessId,
                Name = mt.Tag!.Name
            })
            .OrderBy(t => t.Name)
            .ToListAsync();
    }

    /// <summary>
    /// Gets checkboxes for tags filtered by mood, organized by tag categories.
    /// </summary>
    public async Task<IEnumerable<GetTagsCheckBoxesListDto>> GetTagsCheckBoxesByMood(int? moodId)
    {
        return await _context.TagCategories
            .Include(tc => tc.Tags)
                .ThenInclude(tag => tag.MoodTags)
            .OrderBy(tc => tc.Name)
            .Select(tc => new GetTagsCheckBoxesListDto
            {
                Category = new TagCategoryDto
                {
                    BusinessId = tc.BusinessId,
                    Name = tc.Name
                },
                TagsCheckBoxes = tc.Tags
                    .Select(tag => new GetTagsCheckBoxesDto
                    {
                        BusinessId = tag.BusinessId,
                        Name = tag.Name,
                        IsChecked = tag.MoodTags != null && tag.MoodTags.Any(mt => mt.MoodId == moodId)
                    })
                    .OrderBy(tag => tag.Name)
                    .ToList()
            })
            .ToListAsync();
    }

    /// <summary>
    /// Retrieves a complete list of tags categorized by tag categories.
    /// </summary>
    public async Task<IEnumerable<GetTagsFullListQueryVm>> GetTagsFullListAsync()
    {
        return await _context.TagCategories
            .OrderBy(tc => tc.Name)
            .Select(tc => new GetTagsFullListQueryVm
            {
                Category = new TagCategoryDto { BusinessId = tc.BusinessId, Name = tc.Name },
                Tags = tc.Tags.OrderBy(t => t.Name)
                            .Select(t => new TagDto { BusinessId = t.BusinessId, Name = t.Name }).ToList()
            })
            .ToListAsync();
    }

    /// <summary>
    /// Finds a tag by its name.
    /// </summary>
    public async Task<Tag?> GetByName(string name)
    {
        return await _context.Set<Tag>()
                             .SingleOrDefaultAsync(x => x.Name == name);
    }
}
