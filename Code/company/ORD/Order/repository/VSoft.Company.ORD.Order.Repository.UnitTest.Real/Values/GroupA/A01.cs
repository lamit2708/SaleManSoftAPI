using VSoft.Company.ORD.Order.Data.Entity.Models;
using VSoft.Company.ORD.Order.Repository.UnitTest.Bases;

namespace VSoft.Company.ORD.Order.Repository.UnitTest.Real.Values.GroupA
{
    public class A01 : TestEntity
    {
        protected override MOrderEntity Entity => new MOrderEntity()
        {
            //Id = 63452,
            Id = 1,
        };
    }
}
