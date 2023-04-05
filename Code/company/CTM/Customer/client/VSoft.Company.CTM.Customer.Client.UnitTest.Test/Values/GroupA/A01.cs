using VSoft.Company.CTM.Customer.Business.Dto.Data;
using VSoft.Company.CTM.Customer.Client.UnitTest.Bases;

namespace VSoft.Company.CTM.Customer.Client.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override CustomerDto Dto => new CustomerDto()
        {
           
            Name = "Đặng Thế Nhân",

        };
    }
}
