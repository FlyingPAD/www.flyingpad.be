using MB.Application.Models;

namespace MB.Application.Features.Tasks.Queries.CountTasks;

public class CountTasksQueryResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public int TasksCount { get; set; }

    public CountTasksQueryResponse() : base ()
    {

    }
}
