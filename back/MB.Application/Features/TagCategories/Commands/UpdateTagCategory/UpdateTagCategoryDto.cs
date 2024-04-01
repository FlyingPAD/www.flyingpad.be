namespace MB.Application.Features.TagCategories.Commands.UpdateTagCategory
{
    public class UpdateTagCategoryDto
    {
        public Guid BusinessId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
