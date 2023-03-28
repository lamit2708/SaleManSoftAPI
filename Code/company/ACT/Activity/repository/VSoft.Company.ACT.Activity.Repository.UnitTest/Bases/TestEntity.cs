using VSoft.Company.ACT.Activity.Data.Entity.Models;

namespace VSoft.Company.ACT.Activity.Repository.UnitTest.Bases
{
    public abstract class TestEntity
    {
        public virtual MActivityEntity GetCreateEntity()
        {
            var e = Entity;

            return e;
        }

        public virtual MActivityEntity GetCreateEntity(string fullName)
        {
            var e = Entity;
            e.Name = fullName;
            return e;
        }

        public virtual MActivityEntity GetUpdateEntity(int id)
        {
            var e = Entity;
            e.Id = id;
            return e;
        }

        public virtual MActivityEntity GetUpdateEntityFromData(string data)
        {
            var e = Entity;
            var arr = data.Split(" / ");
            e.Id = Convert.ToInt32(arr[0]);
            e.Name = arr[1];
            return e;
        }

        public virtual MActivityEntity GetUpdateEntity(int id, string fullName)
        {
            var e = Entity;
            e.Id = id;
            e.Name = fullName;
            return e;
        }

        protected abstract MActivityEntity Entity { get; }
    }
}
