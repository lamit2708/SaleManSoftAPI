using VSoft.Company.ACT.Activity.Business.Dto.Data;
using VSoft.Company.ACT.Activity.Client.UnitTest.Bases;

namespace VSoft.Company.ACT.Activity.Client.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override ActivityDto Dto => new ActivityDto()
        {
           
            FullName = "Đặng Thế Nhân",
          
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,

        };
    }
}
