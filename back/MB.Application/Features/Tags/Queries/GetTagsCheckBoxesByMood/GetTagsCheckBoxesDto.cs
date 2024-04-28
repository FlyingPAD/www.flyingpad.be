namespace MB.Application.Features.Tags.Queries.GetTagsCheckBoxesByMood
{
    public class GetTagsCheckBoxesDto
    {
        public Guid BusinessId { get; set; } = Guid.Empty;
        public string Name { get; set; } = string.Empty;
        public bool IsChecked { get; set; } = false;
    }
}
