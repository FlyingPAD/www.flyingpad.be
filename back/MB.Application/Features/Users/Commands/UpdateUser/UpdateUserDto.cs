namespace MB.Application.Features.Users.Commands.UpdateUser;

public class UpdateUserDto
{
    public DateTime? Created { get; set; }
    public DateTime? Modified { get; set; }
    public Guid BusinessId { get; set; }
    public DateTime Birthdate { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}
