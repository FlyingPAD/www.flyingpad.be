﻿using MB.Application.Models;

namespace MB.Application.Features.Links.Queries.GetLinkById;

public class GetLinkByIdQueryResponse : BaseResponse
{
    public GetLinkByIdVm Link { get; set; } = new GetLinkByIdVm();
}