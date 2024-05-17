namespace MB.Application.Features.Users.Queries.GetUserById;

public class GetUserByIdVm
{
    public Guid BusinessId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public string? ModifiedBy { get; set; }
}
