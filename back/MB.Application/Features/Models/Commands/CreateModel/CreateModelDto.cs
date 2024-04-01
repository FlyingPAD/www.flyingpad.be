namespace MB.Application.Features.Models.Commands.CreateModel
{
    public class CreateModelDto
    {
        public Guid BusinessId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}
