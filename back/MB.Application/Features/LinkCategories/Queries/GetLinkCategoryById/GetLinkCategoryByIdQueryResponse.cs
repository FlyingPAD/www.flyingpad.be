﻿using MB.Application.Models;

namespace MB.Application.Features.LinkCategories.Queries.GetLinkCategoryById;

public class GetLinkCategoryByIdQueryResponse : BaseResponse
{
    public GetLinkCategoryByIdVm LinkCategory { get; set; } = new GetLinkCategoryByIdVm();
}