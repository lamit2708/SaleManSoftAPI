using VSoft.Company.URO.UserRole.Data.Entity.Models;

namespace VSoft.Company.URO.UserRole.Repository.UnitTest.Bases
{
    public abstract class TestEntity
    {
        public virtual MUserRoleEntity GetCreateEntity()
        {
            var e = Entity;

            return e;
        }

        public virtual MUserRoleEntity GetCreateEntity(string fullName)
        {
            var e = Entity;
            //e.Name = fullName;
            return e;
        }

        public virtual MUserRoleEntity GetUpdateEntity(int id)
        {
            var e = Entity;
            e.Id = id;
            return e;
        }

        public virtual MUserRoleEntity GetUpdateEntityFromData(string data)
        {
            var e = Entity;
            var arr = data.Split(" / ");
            e.Id = Convert.ToInt32(arr[0]);
            //e.Name = arr[1];
            return e;
        }

        public virtual MUserRoleEntity GetUpdateEntity(int id, string fullName)
        {
            var e = Entity;
            e.Id = id;
            //e.Name = fullName;
            return e;
        }

        protected abstract MUserRoleEntity Entity { get; }
    }
}
