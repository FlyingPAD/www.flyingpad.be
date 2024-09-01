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
    public async Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds)
    {
        return await _context.Tags
                             .Where(tag => businessIds.Contains(tag.BusinessId))
                             .Select(tag => tag.EntityId)
                             .ToListAsync();
    }

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

    public async Task<IEnumerable<GetTagsCheckBoxesListDto>> GetTagsCheckBoxesByMood(int? moodId)
    {
        var tagCategories = await _context.TagCategories
            .AsNoTracking()
            .OrderBy(tc => tc.Name)
            .Select(tc => new
            {
                tc.BusinessId,
                tc.Name,
                Tags = tc.Tags
                    .OrderBy(tag => tag.Name)
                    .Select(tag => new
                    {
                        tag.BusinessId,
                        tag.Name,
                        IsChecked = tag.MoodTags != null && tag.MoodTags.Any(mt => mt.MoodId == moodId)
                    })
                    .ToList()
            })
            .ToListAsync();

        return tagCategories.Select(tc => new GetTagsCheckBoxesListDto
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
                    IsChecked = tag.IsChecked
                })
                .ToList()
        });
    }

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

    public async Task<Tag?> GetByName(string name)
    {
        return await _context.Set<Tag>()
                             .SingleOrDefaultAsync(x => x.Name == name);
    }


    public async Task<List<Tag>> GetByCategory(int categoryId)
    {
        return await _context.Tags
                             .Where(tag => tag.TagCategoryId == categoryId)
                             .OrderBy(tag => tag.Name)
                             .ToListAsync();
    }

    public async Task<Guid> GetTagCategoryBusinessId(int tagCategoryId)
    {
        var tagCategory = await _context.Set<TagCategory>()
            .SingleOrDefaultAsync(tagCategory => tagCategory.EntityId == tagCategoryId);

        if(tagCategory == null)
        {
            return Guid.Empty;
        }
        else
        {
            return tagCategory.BusinessId;
        }
    }

    public async System.Threading.Tasks.Task DeleteTagRelations(int tagId)
    {
        var moodTagRelations = await _context.RMoodTag
                                .Where(relation => relation.TagId == tagId)
                                .ToListAsync();

        _context.RMoodTag.RemoveRange(moodTagRelations);

        await _context.SaveChangesAsync();
    }
}