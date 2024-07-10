namespace MB.Application.Features.Users.Queries.GetUsersList;

public class GetUsersListQueryResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    /// 
    public List<UserListVm> UsersList { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public GetUsersListQueryResponse() : base()
    {

    }
}
