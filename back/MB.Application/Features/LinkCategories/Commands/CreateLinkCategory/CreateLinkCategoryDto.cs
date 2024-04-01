namespace MB.Application.Features.LinkCategories.Commands.CreateLinkCategory
{
    public class CreateLinkCategoryDto
    {
        public Guid BusinessId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
