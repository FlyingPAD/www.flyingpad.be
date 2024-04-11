using MB.Application.Contracts.Persistence;
using MB.Application.Features.Tags.Queries.GetTagsByMood;
using MB.Application.Features.Tags.Queries.GetTagsFullListQuery;
using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories
{
    public class TagRepository(Context context) : BaseRepository<Tag>(context), ITagRepository
    {
        public async Task<IEnumerable<GetTagsByMoodQueryVm>> GetTagsByMood(int? moodId)
        {
            var tagsVm = await _context.RMoodTag
                .Where(mt => mt.MoodId == moodId && mt.Tag != null)
                .Select(mt => new GetTagsByMoodQueryVm
                {
                    BusinessId = mt.Tag!.BusinessId,
                    Name = mt.Tag!.Name
                })
                .OrderBy(t => t.Name)
                .ToListAsync();

            return tagsVm;
        }

        public async Task<IEnumerable<GetTagsFullListQueryVm>> GetTagsFullListAsync()
        {
            var categoriesWithTags = await _context.TagCategories
                .OrderBy(tc => tc.Name)
                .Select(tc => new GetTagsFullListQueryVm
                {
                    Category = new TagCategoryDto { BusinessId = tc.BusinessId, Name = tc.Name },
                    Tags = tc.Tags.OrderBy(t => t.Name)
                                .Select(t => new TagDto { BusinessId = t.BusinessId, Name = t.Name }).ToList()
                })
                .ToListAsync();

            return categoriesWithTags;
        }
    }
}