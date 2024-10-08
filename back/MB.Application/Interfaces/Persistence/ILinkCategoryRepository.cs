﻿using MB.Application.Features.LinkCategories.Queries.GetLinkCategoriesCheckBoxesByLink;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;

namespace MB.Application.Interfaces.Persistence;

public interface ILinkCategoryRepository : IBaseRepository<LinkCategory>
{
    Task<IEnumerable<GetLinkCategoriesCheckBoxesByLinkQueryDto>> GetCheckBoxesByLink(int linkId);
    Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds);
}
