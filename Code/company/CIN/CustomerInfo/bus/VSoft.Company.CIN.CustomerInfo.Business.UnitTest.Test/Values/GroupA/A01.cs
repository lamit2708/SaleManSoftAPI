using VSoft.Company.CIN.CustomerInfo.Business.Dto.Data;
using VSoft.Company.CIN.CustomerInfo.Business.UnitTest.Bases;

namespace VSoft.Company.CIN.CustomerInfo.Business.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override CustomerInfoDto Dto => new CustomerInfoDto()
        {
         
            //Name = "Đặng Thế Nhân",
            CustomerSourceId = 1,
        };
    }
}
