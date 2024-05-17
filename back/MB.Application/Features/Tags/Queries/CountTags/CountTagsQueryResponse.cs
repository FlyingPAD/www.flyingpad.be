using MB.Application.Responses;

namespace MB.Application.Features.Tags.Queries.CountTags;

public class CountTagsQueryResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public int TagsCount { get; set; }

    public CountTagsQueryResponse() : base ()
    {

    }
}
