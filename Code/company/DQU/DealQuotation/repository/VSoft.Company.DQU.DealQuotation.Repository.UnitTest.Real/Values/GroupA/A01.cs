using VSoft.Company.DQU.DealQuotation.Data.Entity.Models;
using VSoft.Company.DQU.DealQuotation.Repository.UnitTest.Bases;

namespace VSoft.Company.DQU.DealQuotation.Repository.UnitTest.Real.Values.GroupA
{
    public class A01 : TestEntity
    {
        protected override MDealQuotationEntity Entity => new MDealQuotationEntity()
        {
            Id = 1,
        };
    }
}
