using VSoft.Company.UCU.UserCustomer.Business.Dto.Data;
using VSoft.Company.UCU.UserCustomer.Client.UnitTest.Bases;

namespace VSoft.Company.UCU.UserCustomer.Client.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override UserCustomerDto Dto => new UserCustomerDto()
        {
           
            FullName = "Đặng Thế Nhân",
          
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,

        };
    }
}
