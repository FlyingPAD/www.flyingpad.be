using MB.Application.Models;

namespace MB.Application.Features.Medias.Queries.GetMediumById;

public class GetMediumByIdQueryResponse : BaseResponse
{
    public GetMediumByIdQueryDto Medium { get; set; } = new();
}