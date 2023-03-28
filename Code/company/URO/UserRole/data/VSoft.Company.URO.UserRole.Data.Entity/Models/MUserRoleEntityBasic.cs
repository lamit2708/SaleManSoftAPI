using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.URO.UserRole.Data.Entity.Models
{
    public class MUserRoleEntityBasic : IIdEntity<long>
    {
        public long Id { get; set; }

        public int RoleId { get; set; }

        public int UserId { get; set; }
    }
}
