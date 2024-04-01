namespace MB.Application.Features.Models.Queries.GetModelById
{
    public class GetModelByIdVm
    {
        public Guid BusinessId { get; set; } = Guid.Empty;
        public DateTime Created { get; set; } = DateTime.MinValue;
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime Modified { get; set; } = DateTime.MinValue;
        public string ModifiedBy { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Pseudonym { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
