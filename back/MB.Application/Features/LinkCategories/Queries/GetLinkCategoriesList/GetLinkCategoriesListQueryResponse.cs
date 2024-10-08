﻿using MB.Application.Models;

namespace MB.Application.Features.LinkCategories.Queries.GetLinkCategoriesList;

public class GetLinkCategoriesListQueryResponse : BaseResponse
{
    public List<LinkCategoryListVm> LinkCategories { get; set; } = new List<LinkCategoryListVm>();
}
