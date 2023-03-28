using VSoft.Company.USR.User.Business.Dto.Data;
using VSoft.Company.USR.User.Client.UnitTest.Bases;

namespace VSoft.Company.USR.User.Client.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override UserDto Dto => new UserDto()
        {
           
            FullName = "Đặng Thế Nhân",
          
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,

        };
    }
}
