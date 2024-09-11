using MB.Application.Features.Tags.Queries.GetTagsByMood;
using MB.Application.Features.Tags.Queries.GetTagsCheckBoxesByMood;
using MB.Application.Features.Tags.Queries.GetTagsFullListQuery;
using MB.Application.Interfaces.Persistence;
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
            .Where(relation => relation.MoodId == moodId && relation.Tag != null)
            .Select(relation => new GetTagsByMoodQueryVm
            {
                BusinessId = relation.Tag!.BusinessId,
                Name = relation.Tag!.Name
            })
            .OrderBy(tag => tag.Name)
            .ToListAsync();
    }

    public async Task<IEnumerable<GetTagsCheckBoxesListDto>> GetTagsCheckBoxesByMood(int? moodId)
    {
        var moodTagsDictionary = await _context.RMoodTag
            .Where(relation => relation.MoodId == moodId)
            .ToDictionaryAsync(relation => relation.TagId, relation => true);

        var tagCategories = await _context.TagCategories
            .AsNoTracking()
            .OrderBy(category => category.Name)
            .Select(category => new
            {
                category.BusinessId,
                category.Name,
                Tags = category.Tags
                    .OrderBy(tag => tag.Name)
                    .Select(tag => new
                    {
                        tag.BusinessId,
                        tag.Name,
                        IsChecked = moodTagsDictionary.ContainsKey(tag.EntityId)
                    })
                    .ToList()
            })
            .ToListAsync();

        return tagCategories.Select(category => new GetTagsCheckBoxesListDto
        {
            Category = new TagCategoryDto
            {
                BusinessId = category.BusinessId,
                Name = category.Name
            },
            TagsCheckBoxes = category.Tags
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
            .OrderBy(category => category.Name)
            .Select(category => new GetTagsFullListQueryVm
            {
                Category = new TagCategoryDto { BusinessId = category.BusinessId, Name = category.Name },
                Tags = category.Tags.OrderBy(t => t.Name)
                            .Select(tag => new TagDto { BusinessId = tag.BusinessId, Name = tag.Name }).ToList()
            })
            .ToListAsync();
    }

    public async Task<Tag?> GetByName(string name)
    {
        return await _context.Set<Tag>()
                             .SingleOrDefaultAsync(tag => tag.Name == name);
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