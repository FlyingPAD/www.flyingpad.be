using MB.Application.Responses;

namespace MB.Application.Features.TaskCategories.Queries.CountTaskCategories;

public class CountTaskCategoriesQueryResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public int TaskCategoriesCount { get; set; }

    public CountTaskCategoriesQueryResponse() : base()
    {

    }
}
