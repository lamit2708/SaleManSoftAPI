using VSoft.Company.URO.UserRole.Business.Dto.Data;
using VSoft.Company.URO.UserRole.Client.UnitTest.Bases;

namespace VSoft.Company.URO.UserRole.Client.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override UserRoleDto Dto => new UserRoleDto()
        {
           
            FullName = "Đặng Thế Nhân",
          
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,

        };
    }
}
