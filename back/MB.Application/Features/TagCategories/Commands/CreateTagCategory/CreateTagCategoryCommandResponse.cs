﻿using MB.Application.Models;

namespace MB.Application.Features.TagCategories.Commands.CreateTagCategory;

public class CreateTagCategoryCommandResponse : BaseResponse
{
    public Guid TagCategoryId { get; set; }
}