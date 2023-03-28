using VSoft.Company.URO.UserRole.Business.Dto.Data;
using VSoft.Company.URO.UserRole.Business.UnitTest.Bases;

namespace VSoft.Company.URO.UserRole.Business.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override UserRoleDto Dto => new UserRoleDto()
        {
            Id = 1
        };
    }
}
