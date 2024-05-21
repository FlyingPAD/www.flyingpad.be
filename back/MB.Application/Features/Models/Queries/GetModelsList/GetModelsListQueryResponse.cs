using MB.Application.Responses;

namespace MB.Application.Features.Models.Queries.GetModelsList;

public class GetModelsListQueryResponse : BaseResponse
{
    public List<ModelListVm> Models { get; set; } = [];
}
