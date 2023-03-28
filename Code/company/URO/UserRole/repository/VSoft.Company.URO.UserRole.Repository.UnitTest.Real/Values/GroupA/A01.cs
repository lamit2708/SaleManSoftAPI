using VSoft.Company.URO.UserRole.Data.Entity.Models;
using VSoft.Company.URO.UserRole.Repository.UnitTest.Bases;

namespace VSoft.Company.URO.UserRole.Repository.UnitTest.Real.Values.GroupA
{
    public class A01 : TestEntity
    {
        protected override MUserRoleEntity Entity => new MUserRoleEntity()
        {
            Id = 1,
        };
    }
}
