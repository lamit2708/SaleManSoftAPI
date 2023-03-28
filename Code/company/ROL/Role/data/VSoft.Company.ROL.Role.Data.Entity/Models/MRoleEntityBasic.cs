using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.ROL.Role.Data.Entity.Models
{
    public class MRoleEntityBasic : IIdEntity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
