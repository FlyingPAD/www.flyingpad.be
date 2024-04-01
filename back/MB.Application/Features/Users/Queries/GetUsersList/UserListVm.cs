namespace MB.Application.Features.Users.Queries.GetUsersList
{
    public class UserListVm
    {
        public Guid BusinessId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}
