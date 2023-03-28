using VSoft.Company.ROL.Role.Data.Entity.Models;

namespace VSoft.Company.ROL.Role.Repository.UnitTest.Bases
{
    public abstract class TestEntity
    {
        public virtual MRoleEntity GetCreateEntity()
        {
            var e = Entity;

            return e;
        }

        public virtual MRoleEntity GetCreateEntity(string fullName)
        {
            var e = Entity;
            e.Name = fullName;
            return e;
        }

        public virtual MRoleEntity GetUpdateEntity(int id)
        {
            var e = Entity;
            e.Id = id;
            return e;
        }

        public virtual MRoleEntity GetUpdateEntityFromData(string data)
        {
            var e = Entity;
            var arr = data.Split(" / ");
            e.Id = Convert.ToInt32(arr[0]);
            e.Name = arr[1];
            return e;
        }

        public virtual MRoleEntity GetUpdateEntity(int id, string fullName)
        {
            var e = Entity;
            e.Id = id;
            e.Name = fullName;
            return e;
        }

        protected abstract MRoleEntity Entity { get; }
    }
}
