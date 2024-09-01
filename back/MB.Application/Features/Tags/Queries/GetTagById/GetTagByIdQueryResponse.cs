using MB.Application.Models;

namespace MB.Application.Features.Tags.Queries.GetTagById;

public class GetTagByIdQueryResponse : BaseResponse
{
    public GetTagByIdVm Tag { get; set; } = new GetTagByIdVm();
}