using MB.Application.Contracts.Persistence;
using MB.Application.Features.Tags.Queries.GetTagsByMood;
using MB.Application.Features.Tags.Queries.GetTagsCheckBoxesByMood;
using MB.Application.Features.Tags.Queries.GetTagsFullListQuery;
using MB.Domain.Common;
using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories
{
    public class TagRepository(Context context) : BaseRepository<Tag>(context), ITagRepository
    {
        public async Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds)
        {
            // Use LINQ to query styles by business ID and select their entity ID.

            return await _context.Tags
                                 .Where(tag => businessIds.Contains(tag.BusinessId))
                                 .Select(tag => tag.EntityId)
                                 .ToListAsync();
        }

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

        public async Task<IEnumerable<GetTagsCheckBoxesListDto>> GetTagsCheckBoxesByMood(int? moodId)
        {
            var categoriesWithTags = await _context.TagCategories
                .Include(tc => tc.Tags)
                    .ThenInclude(tag => tag.MoodTags)
                .OrderBy(tc => tc.Name) // Ajoutez cette ligne pour trier les catégories par nom
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
                            IsChecked = tag.MoodTags.Any(mt => mt.MoodId == moodId)
                        })
                        .OrderBy(tag => tag.Name)
                        .ToList()
                })
                .ToListAsync();

            return categoriesWithTags;
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

        /// <summary>
        /// Get Tag by Name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>The Tag object with the specified name.</returns>
        public async Task<Tag?> GetByName(string name)
        {
            return await _context.Set<Tag>()
                                 .SingleOrDefaultAsync(x => x.Name == name);
        }
    }
}