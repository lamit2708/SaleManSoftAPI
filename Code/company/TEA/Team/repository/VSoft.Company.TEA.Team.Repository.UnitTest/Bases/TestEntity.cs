using VSoft.Company.TEA.Team.Data.Entity.Models;

namespace VSoft.Company.TEA.Team.Repository.UnitTest.Bases
{
    public abstract class TestEntity
    {
        public virtual MTeamEntity GetCreateEntity()
        {
            var e = Entity;

            return e;
        }

        public virtual MTeamEntity GetCreateEntity(string fullName)
        {
            var e = Entity;
            e.Name = fullName;
            return e;
        }

        public virtual MTeamEntity GetUpdateEntity(int id)
        {
            var e = Entity;
            e.Id = id;
            return e;
        }

        public virtual MTeamEntity GetUpdateEntityFromData(string data)
        {
            var e = Entity;
            var arr = data.Split(" / ");
            e.Id = Convert.ToInt32(arr[0]);
            e.Name = arr[1];
            return e;
        }

        public virtual MTeamEntity GetUpdateEntity(int id, string fullName)
        {
            var e = Entity;
            e.Id = id;
            e.Name = fullName;
            return e;
        }

        protected abstract MTeamEntity Entity { get; }
    }
}
