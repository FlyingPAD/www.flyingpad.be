namespace MB.Application.Features.Medias.Commands.UpdateMedia
{
    public class UpdateMediaDto
    {
        public Guid BusinessId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
