﻿using MB.Application.Models;

namespace MB.Application.Features.Tags.Queries.CountTags;

public class CountTagsQueryResponse : BaseResponse
{
    public int TotalTags { get; set; }
}