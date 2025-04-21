namespace MB.Application.Features.Models.Queries.GetModelById;

public class GetModelByIdQueryResponse : BaseResponse
{
    public GetModelByIdQueryDto Model { get; set; } = new();
}