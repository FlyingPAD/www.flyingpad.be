namespace MB.Application.Features.LinkCategories.Queries.GetAllLinkCategories;

public class GetAllLinkCategoriesQueryDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
}