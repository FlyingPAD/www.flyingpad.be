namespace MB.Application.Features.Styles.Queries.GetStylesCheck
{
    public class GetStylesCheckQueryDto
    {
        public Guid BusinessId { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsChecked { get; set; } = false;
    }
}