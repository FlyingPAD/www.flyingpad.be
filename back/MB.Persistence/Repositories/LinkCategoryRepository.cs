using MB.Application.Contracts.Persistence;
using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories
{
    public class LinkCategoryRepository(Context context) : BaseRepository<LinkCategory>(context), ILinkCategoryRepository
    {

    }
}
