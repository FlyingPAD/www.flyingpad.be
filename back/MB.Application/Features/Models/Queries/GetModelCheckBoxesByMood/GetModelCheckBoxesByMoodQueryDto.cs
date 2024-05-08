namespace MB.Application.Features.Models.Queries.GetModelCheckBoxesByMood
{
    public class GetModelCheckBoxesByMoodQueryDto
    {
        public Guid BusinessId { get; set; } = Guid.Empty;
        public string Pseudonym { get; set; } = "";
        public bool IsChecked { get; set; } = false; 
    }
}
