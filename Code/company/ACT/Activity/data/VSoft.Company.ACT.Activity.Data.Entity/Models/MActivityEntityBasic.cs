using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.ACT.Activity.Data.Entity.Models
{
    public class MActivityEntityBasic : IIdEntity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
