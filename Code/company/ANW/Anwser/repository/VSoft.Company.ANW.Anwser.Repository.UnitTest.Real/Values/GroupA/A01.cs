using VSoft.Company.ANW.Anwser.Data.Entity.Models;
using VSoft.Company.ANW.Anwser.Repository.UnitTest.Bases;

namespace VSoft.Company.ANW.Anwser.Repository.UnitTest.Real.Values.GroupA
{
    public class A01 : TestEntity
    {
        protected override MAnwserEntity Entity => new MAnwserEntity()
        {
            Id = 1,
        };
    }
}
