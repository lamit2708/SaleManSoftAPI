using VSoft.Company.DAC.DealActivity.Data.Entity.Models;
using VSoft.Company.DAC.DealActivity.Repository.UnitTest.Bases;

namespace VSoft.Company.DAC.DealActivity.Repository.UnitTest.Real.Values.GroupA
{
    public class A01 : TestEntity
    {
        protected override MDealActivityEntity Entity => new MDealActivityEntity()
        {
            Id = 1,
        };
    }
}
