using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.DEA.Deal.Data.Entity.Models
{
    public class MDealEntityBasic : IIdEntity<long>
    {
        public long Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public long DealId { get; set; }

        public int DealStepId { get; set; }

        public int UserId { get; set; }

        public int? OrderId { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }
    }
}
