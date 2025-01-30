namespace MB.Application.Features.Users.Commands.UpdateUser;

public class UpdateUserDto
{
    public DateTime? Modified { get; set; }
    public DateTime Birthdate { get; set; }
    public string Pseudonym { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}