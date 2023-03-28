using VSoft.Company.UCU.UserCustomer.Data.Entity.Models;
using VSoft.Company.UCU.UserCustomer.Repository.UnitTest.Bases;

namespace VSoft.Company.UCU.UserCustomer.Repository.UnitTest.Real.Values.GroupA
{
    public class A01 : TestEntity
    {
        protected override MUserCustomerEntity Entity => new MUserCustomerEntity()
        {
            Id = 1,
        };
    }
}
