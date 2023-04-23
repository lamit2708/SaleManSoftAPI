using VSoft.Company.PRF.ProductFeature.Data.Entity.Models;
using VSoft.Company.PRF.ProductFeature.Repository.UnitTest.Bases;

namespace VSoft.Company.PRF.ProductFeature.Repository.UnitTest.Real.Values.GroupA
{
    public class A01 : TestEntity
    {
        protected override MProductFeatureEntity Entity => new MProductFeatureEntity()
        {
            Id = 1,
        };
    }
}
