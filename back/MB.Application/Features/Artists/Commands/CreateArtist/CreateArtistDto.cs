namespace MB.Application.Features.Artists.Commands.CreateArtist
{
    public class CreateArtistDto
    {
        public Guid BusinessId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
