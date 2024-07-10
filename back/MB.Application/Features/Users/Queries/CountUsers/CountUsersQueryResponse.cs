namespace MB.Application.Features.Users.Queries.CountUsers;

public class CountUsersQueryResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public int UsersCount { get; set; }

    public CountUsersQueryResponse() : base ()
    {

    }
}
