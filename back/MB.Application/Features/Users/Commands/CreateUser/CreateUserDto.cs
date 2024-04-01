namespace MB.Application.Features.Users.Commands.CreateUser
{
    public class CreateUserDto
    {
        public Guid BusinessId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}
