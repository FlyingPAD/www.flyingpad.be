namespace MB.Application.Features.Models.Queries.GetModelById;

public class GetModelByIdQueryResponse : BaseResponse
{
    public GetModelByIdVm Model { get; set; } = default!;
}