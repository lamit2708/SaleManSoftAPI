using VSoft.Company.ROL.Role.Data.Entity.Models;
using VSoft.Company.ROL.Role.Repository.UnitTest.Bases;

namespace VSoft.Company.ROL.Role.Repository.UnitTest.Real.Values.GroupA
{
    public class A01 : TestEntity
    {
        protected override MRoleEntity Entity => new MRoleEntity()
        {
            Name = "Đặng Thế Nhân",
        };
    }
}
