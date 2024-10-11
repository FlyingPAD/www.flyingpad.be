namespace MB.Application.Features.Medias.Queries
{
    public class GetMediaCheckBoxesByFranchiseQueryDto
    {
        public Guid BusinessId { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsChecked { get; set; }
    }
}