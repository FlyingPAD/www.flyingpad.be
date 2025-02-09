namespace MB.Application.Features.Users.Queries.GetUserById;

public class GetUserByIdQueryDto
{
    public Guid BusinessId { get; set; }
    public string Email { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Experience { get; set; }
    public int Level { get; set; } = 1;
    public DateTime Birthdate { get; set; }
    public DateTime Created { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime Modified { get; set; }
    public string? ModifiedBy { get; set; }
}