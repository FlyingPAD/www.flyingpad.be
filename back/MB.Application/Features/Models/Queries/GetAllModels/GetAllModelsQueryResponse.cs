namespace MB.Application.Features.Models.Queries.GetAllModels;

public class GetAllModelsQueryResponse : BaseResponse
{
    public List<GetAllModelsQueryDto> Models { get; set; } = [];
}