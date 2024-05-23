namespace MB.Application.Features.Tags.Queries.GetTagsByCategory
{
    public class GetTagsByCategoryQueryDto
    {
        public Guid BusinessId { get; set; } = Guid.Empty;
        public string Name { get; set; } = string.Empty;
    }
}