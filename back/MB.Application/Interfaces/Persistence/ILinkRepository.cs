﻿using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Common;
using MB.Domain.Entities;

namespace MB.Application.Interfaces.Persistence;

public interface ILinkRepository : IBaseRepository<Link>
{
    Task<List<Link>> GetLinksListByCategory(int? linkCategoryId);
    Task<List<Link>> GetLinksContainingAbc(string? abc);
    Task<PaginationCursor<Link>> GetPageLinksContainingAbc(string abc, Guid startId, int pageSize, bool isFirstItem);
    System.Threading.Tasks.Task AddLinkCategoriesAsync(int linkId, IEnumerable<int> categoryIds);
    System.Threading.Tasks.Task RemoveLinkCategoriesAsync(Link link);
    Task<Link?> GetLinkWithCategoriesAsync(int linkId);
    Task<IEnumerable<Link>> GetLinksByArtist(int artistId);
    Task<IEnumerable<Link>> GetLinksByModel(int modelId);
}