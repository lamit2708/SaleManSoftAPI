using VSoft.Company.UCU.UserCustomer.Business.Dto.Data;
using VSoft.Company.UCU.UserCustomer.Business.UnitTest.Bases;

namespace VSoft.Company.UCU.UserCustomer.Business.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override UserCustomerDto Dto => new UserCustomerDto()
        {
            Id = 1
        };
    }
}
