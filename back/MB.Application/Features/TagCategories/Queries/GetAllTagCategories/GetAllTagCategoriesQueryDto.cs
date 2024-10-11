namespace MB.Application.Features.TagCategories.Queries.GetAllTagCategories;

public class GetAllTagCategoriesQueryDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
}
