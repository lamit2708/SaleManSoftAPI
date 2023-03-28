using VSoft.Company.TEA.Team.Data.Entity.Models;
using VSoft.Company.TEA.Team.Repository.UnitTest.Bases;

namespace VSoft.Company.TEA.Team.Repository.UnitTest.Real.Values.GroupA
{
    public class A01 : TestEntity
    {
        protected override MTeamEntity Entity => new MTeamEntity()
        {
            Id = 1,
        };
    }
}
