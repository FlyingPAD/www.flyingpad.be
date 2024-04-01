namespace MB.Application.Features.LinkCategories.Queries.GetLinkCategoriesList
{
    public class LinkCategoryListVm
    {
        public Guid BusinessId { get; set; } = Guid.Empty;
        public string Name { get; set; } = string.Empty;
    }
}