namespace MB.Application.Features.Links.Commands.UpdateLink
{
    public class UpdateLinkDto
    {
        public Guid BusinessId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
