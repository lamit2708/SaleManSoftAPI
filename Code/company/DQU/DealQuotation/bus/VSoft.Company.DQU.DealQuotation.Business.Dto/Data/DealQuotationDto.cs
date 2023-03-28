

namespace VSoft.Company.DQU.DealQuotation.Business.Dto.Data
{
    public class DealQuotationDto
    {
        public long Id { get; set; }

        public long DealId { get; set; }

        public int ProductId { get; set; }

        public int Quatitty { get; set; }

        public int UserId { get; set; }

        public DateTime CreatedDate { get; set; }

        public override string ToString()
        {
            return $"{Id} / {DealId}";
        }
    }
}
