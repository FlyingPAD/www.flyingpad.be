﻿using MB.Application.Models;

namespace MB.Application.Features.Medias.Queries.CountMedias;

public class CountMediasQueryResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public int MediasCount { get; set; }

    public CountMediasQueryResponse() : base ()
    {

    }
}
