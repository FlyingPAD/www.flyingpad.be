using MB.Application.Responses;

namespace MB.Application.Features.Tags.Queries.GetTagsList;

public class GetTagsListQueryResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    /// 
    public List<TagListVm> TagsList { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public GetTagsListQueryResponse() : base()
    {

    }
}
