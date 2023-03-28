using VSoft.Company.POR.ProductOrder.Data.Entity.Models;
using VSoft.Company.POR.ProductOrder.Repository.UnitTest.Bases;

namespace VSoft.Company.POR.ProductOrder.Repository.UnitTest.Test.Values.GroupA
{
    public class A01 : TestEntity
    {
        protected override MProductOrderEntity Entity => new MProductOrderEntity()
        {
            Id = 1,
        };
    }
}
