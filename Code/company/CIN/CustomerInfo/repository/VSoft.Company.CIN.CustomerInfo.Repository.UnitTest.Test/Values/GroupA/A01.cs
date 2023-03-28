using VSoft.Company.CIN.CustomerInfo.Data.Entity.Models;
using VSoft.Company.CIN.CustomerInfo.Repository.UnitTest.Bases;

namespace VSoft.Company.CIN.CustomerInfo.Repository.UnitTest.Test.Values.GroupA
{
    public class A01 : TestEntity
    {
        protected override MCustomerInfoEntity Entity => new MCustomerInfoEntity()
        {
            Id = 1,
        };
    }
}
