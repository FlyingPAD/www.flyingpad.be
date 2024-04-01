namespace MB.Application.Features.Tags.Commands.UpdateTag
{
    public class UpdateTagDto
    {
        public Guid BusinessId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
