namespace VSoft.Company.VDT.VDealTag.Business.Dto.Data
{
    public class VDealTagFilterDto
    {
        public int? UserId { get; set; }
        public int? TeamId { get; set; }
        public DateTime? Date { get; set; }
        public string? Keyword { get; set; }
        public string? Buffer { get; set; }
    }
}
