namespace MB.Application.Features.Tags.Commands.CreateTag
{
    public class CreateTagDto
    {
        public Guid BusinessId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
