namespace MB.Application.Features.Users.Queries.GetUsersList;

public class GetUsersListQueryDto
{
    public Guid BusinessId { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}