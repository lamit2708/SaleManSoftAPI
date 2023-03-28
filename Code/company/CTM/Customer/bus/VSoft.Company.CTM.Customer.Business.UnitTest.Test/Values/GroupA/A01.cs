using VSoft.Company.CTM.Customer.Business.Dto.Data;
using VSoft.Company.CTM.Customer.Business.UnitTest.Bases;

namespace VSoft.Company.CTM.Customer.Business.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override CustomerDto Dto => new CustomerDto()
        {
         
            Name = "Đặng Thế Nhân",
            
        };
    }
}
