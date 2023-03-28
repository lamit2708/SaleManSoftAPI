using VSoft.Company.CIN.CustomerInfo.Business.Dto.Data;
using VSoft.Company.CIN.CustomerInfo.Client.UnitTest.Bases;

namespace VSoft.Company.CIN.CustomerInfo.Client.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override CustomerInfoDto Dto => new CustomerInfoDto()
        {
           
            FullName = "Đặng Thế Nhân",
          
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,

        };
    }
}
