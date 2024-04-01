namespace MB.Application.Features.LinkCategories.Commands.UpdateLinkCategory
{
    public class UpdateLinkCategoryDto
    {
        public Guid BusinessId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
