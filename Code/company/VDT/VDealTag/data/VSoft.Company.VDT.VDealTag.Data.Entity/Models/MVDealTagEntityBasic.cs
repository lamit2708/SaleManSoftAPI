using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.VDT.VDealTag.Data.Entity.Models
{
    public class MVDealTagEntityBasic : IIdEntity<long>
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
    }
}
