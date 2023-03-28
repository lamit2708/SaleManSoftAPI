using VSoft.Company.DEA.Deal.Data.Entity.Models;

namespace VSoft.Company.DEA.Deal.Repository.UnitTest.Bases
{
    public abstract class TestEntity
    {
        public virtual MDealEntity GetCreateEntity()
        {
            var e = Entity;

            return e;
        }

        public virtual MDealEntity GetCreateEntity(string fullName)
        {
            var e = Entity;
            e.Name = fullName;
            return e;
        }

        public virtual MDealEntity GetUpdateEntity(int id)
        {
            var e = Entity;
            e.Id = id;
            return e;
        }

        public virtual MDealEntity GetUpdateEntityFromData(string data)
        {
            var e = Entity;
            var arr = data.Split(" / ");
            e.Id = Convert.ToInt32(arr[0]);
            e.Name = arr[1];
            return e;
        }

        public virtual MDealEntity GetUpdateEntity(int id, string fullName)
        {
            var e = Entity;
            e.Id = id;
            e.Name = fullName;
            return e;
        }

        protected abstract MDealEntity Entity { get; }
    }
}
