
namespace VSoft.Company.VDT.VDealTag.Business.Dto.Data
{
    public class VDealTagDto
    {
        public long Id { get; set; }

        public string? DealName { get; set; }

        public long CustomerId { get; set; }

        public string? CustomerName { get; set; }

        public string? CustomerPhone { get; set; }

        public int UserId { get; set; }

        public string? UserName { get; set; }

        public double PridictPrice { get; set; }

        public int DealStepId { get; set; }

        public int? TeamId { get; set; }

        public DateTime? DateFor { get; set; }

        public override string ToString()
        {
            return $"{Id} / {CustomerName}";
        }
    }
}
