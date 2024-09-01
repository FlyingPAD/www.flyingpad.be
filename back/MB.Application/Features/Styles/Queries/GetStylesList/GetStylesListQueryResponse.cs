using MB.Application.Models;

namespace MB.Application.Features.Styles.Queries.GetStylesList;

public class GetStylesListQueryResponse : BaseResponse
{
    public List<StyleListVm> Styles { get; set; } = [];
}
