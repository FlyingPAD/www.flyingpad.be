namespace MB.Application.Features.TagCategories.Commands.CreateTagCategory
{
    public class CreateTagCategoryDto
    {
        public Guid BusinessId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
