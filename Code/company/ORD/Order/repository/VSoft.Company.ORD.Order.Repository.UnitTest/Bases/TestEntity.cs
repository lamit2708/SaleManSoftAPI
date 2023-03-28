using VSoft.Company.ORD.Order.Data.Entity.Models;

namespace VSoft.Company.ORD.Order.Repository.UnitTest.Bases
{
    public abstract class TestEntity
    {
        public virtual MOrderEntity GetCreateEntity()
        {
            var e = Entity;

            return e;
        }

        public virtual MOrderEntity GetCreateEntity(string fullName)
        {
            var e = Entity;
            //e.Name = fullName;
            return e;
        }

        public virtual MOrderEntity GetUpdateEntity(int id)
        {
            var e = Entity;
            e.Id = id;
            return e;
        }

        public virtual MOrderEntity GetUpdateEntityFromData(string data)
        {
            var e = Entity;
            var arr = data.Split(" / ");
            e.Id = Convert.ToInt32(arr[0]);
            //e.Name = arr[1];
            return e;
        }

        public virtual MOrderEntity GetUpdateEntity(int id, string fullName)
        {
            var e = Entity;
            e.Id = id;
            //e.Name = fullName;
            return e;
        }

        protected abstract MOrderEntity Entity { get; }
    }
}
