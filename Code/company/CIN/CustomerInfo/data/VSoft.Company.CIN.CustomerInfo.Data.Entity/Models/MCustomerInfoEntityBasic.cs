using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.CIN.CustomerInfo.Data.Entity.Models
{
    public class MCustomerInfoEntityBasic : IIdEntity<long>
    {
        public long Id { get; set; }

        public int? CustomerSourceId { get; set; }

        public string? Hobby { get; set; }

        public string? Job { get; set; }

        public DateTime? BirthDate { get; set; }

        public bool? IsMarrage { get; set; }
    }
}
