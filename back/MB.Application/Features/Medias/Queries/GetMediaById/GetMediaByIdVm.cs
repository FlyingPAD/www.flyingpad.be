namespace MB.Application.Features.Medias.Queries.GetMediaById
{
    public class GetMediaByIdVm
    {
        public Guid BusinessId { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
