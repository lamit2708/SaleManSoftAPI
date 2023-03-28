using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.UCU.UserCustomer.Data.Entity.Models
{
    public class MUserCustomerEntityBasic : IIdEntity<int>
    {
        public int Id { get; set; }

        public long CustomerId { get; set; }

        public int? UserId { get; set; }

        public int TeamId { get; set; }

        public DateTime CreatedDateTeam { get; set; }

        public DateTime CreatedDateUser { get; set; }
    }
}
