namespace MB.Application.Features.Users.Commands.UpdateUser;

public class UpdateUserCommandDto
{
    public DateTime? Modified { get; set; }
    public DateTime Birthdate { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}