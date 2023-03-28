using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.DQU.DealQuotation.Data.Entity.Models
{
    public class MDealQuotationEntityBasic : IIdEntity<long>
    {
        public long Id { get; set; }

        public long DealId { get; set; }

        public int ProductId { get; set; }

        public int Quatitty { get; set; }

        public int UserId { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
