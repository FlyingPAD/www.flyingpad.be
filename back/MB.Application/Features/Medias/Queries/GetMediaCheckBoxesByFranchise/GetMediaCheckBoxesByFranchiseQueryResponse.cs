namespace MB.Application.Features.Medias.Queries.GetMediaCheckBoxesByFranchise
{
    public class GetMediaCheckBoxesByFranchiseQueryResponse : BaseResponse
    {
        public GetMediaCheckBoxesByFranchiseQueryDto[] Media { get; set; } = [];
    }
}