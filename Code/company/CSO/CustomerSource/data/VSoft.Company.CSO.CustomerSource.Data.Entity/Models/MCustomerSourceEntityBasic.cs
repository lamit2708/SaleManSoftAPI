using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.CSO.CustomerSource.Data.Entity.Models
{
    public class MCustomerSourceEntityBasic : IIdEntity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
