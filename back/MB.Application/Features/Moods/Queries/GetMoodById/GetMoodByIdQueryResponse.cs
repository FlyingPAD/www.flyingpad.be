using MB.Application.Responses;

namespace MB.Application.Features.Moods.Queries.GetMoodById;

public class GetMoodByIdQueryResponse : BaseResponse
{
    public GetMoodByIdVm Mood { get; set; } = default!;

    public GetMoodByIdQueryResponse() : base()
    {

    }
}