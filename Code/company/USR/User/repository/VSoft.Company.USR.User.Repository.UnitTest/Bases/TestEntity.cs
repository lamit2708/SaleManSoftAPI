using VSoft.Company.USR.User.Data.Entity.Models;

namespace VSoft.Company.USR.User.Repository.UnitTest.Bases
{
    public abstract class TestEntity
    {
        public virtual MUserEntity GetCreateEntity()
        {
            var e = Entity;

            return e;
        }

        public virtual MUserEntity GetCreateEntity(string fullName)
        {
            var e = Entity;
            e.Name = fullName;
            return e;
        }

        public virtual MUserEntity GetUpdateEntity(int id)
        {
            var e = Entity;
            e.Id = id;
            return e;
        }

        public virtual MUserEntity GetUpdateEntityFromData(string data)
        {
            var e = Entity;
            var arr = data.Split(" / ");
            e.Id = Convert.ToInt32(arr[0]);
            e.Name = arr[1];
            return e;
        }

        public virtual MUserEntity GetUpdateEntity(int id, string fullName)
        {
            var e = Entity;
            e.Id = id;
            e.Name = fullName;
            return e;
        }

        protected abstract MUserEntity Entity { get; }
    }
}
