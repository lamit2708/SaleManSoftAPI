using VSoft.Company.POR.ProductOrder.Data.Entity.Models;

namespace VSoft.Company.POR.ProductOrder.Repository.UnitTest.Bases
{
    public abstract class TestEntity
    {
        public virtual MProductOrderEntity GetCreateEntity()
        {
            var e = Entity;

            return e;
        }

        public virtual MProductOrderEntity GetCreateEntity(string fullName)
        {
            var e = Entity;
            //e.Name = fullName;
            return e;
        }

        public virtual MProductOrderEntity GetUpdateEntity(int id)
        {
            var e = Entity;
            e.Id = id;
            return e;
        }

        public virtual MProductOrderEntity GetUpdateEntityFromData(string data)
        {
            var e = Entity;
            var arr = data.Split(" / ");
            e.Id = Convert.ToInt32(arr[0]);
            //e.Name = arr[1];
            return e;
        }

        public virtual MProductOrderEntity GetUpdateEntity(int id, string fullName)
        {
            var e = Entity;
            e.Id = id;
            //e.Name = fullName;
            return e;
        }

        protected abstract MProductOrderEntity Entity { get; }
    }
}
