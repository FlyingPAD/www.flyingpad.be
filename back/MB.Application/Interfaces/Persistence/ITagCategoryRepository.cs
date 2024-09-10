using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;

namespace MB.Application.Interfaces.Persistence;

public interface ITagCategoryRepository : IBaseRepository<TagCategory>
{
    System.Threading.Tasks.Task DeleteTagCategoryTags(int tagId);
}
