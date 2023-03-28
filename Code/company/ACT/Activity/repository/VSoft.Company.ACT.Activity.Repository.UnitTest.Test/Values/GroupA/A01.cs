using VSoft.Company.ACT.Activity.Data.Entity.Models;
using VSoft.Company.ACT.Activity.Repository.UnitTest.Bases;

namespace VSoft.Company.ACT.Activity.Repository.UnitTest.Test.Values.GroupA
{
    public class A01 : TestEntity
    {
        protected override MActivityEntity Entity => new MActivityEntity()
        {
            Id = 1,
        };
    }
}
