using VSoft.Company.CTM.Customer.Data.Entity.Models;

namespace VSoft.Company.CTM.Customer.Repository.UnitTest.Bases
{
    public abstract class TestEntity
    {
        public virtual MCustomerEntity GetCreateEntity()
        {
            var e = Entity;

            return e;
        }

        public virtual MCustomerEntity GetCreateEntity(string fullName)
        {
            var e = Entity;
            e.Name = fullName;
            return e;
        }

        public virtual MCustomerEntity GetUpdateEntity(int id)
        {
            var e = Entity;
            e.Id = id;
            return e;
        }

        public virtual MCustomerEntity GetUpdateEntityFromData(string data)
        {
            var e = Entity;
            var arr = data.Split(" / ");
            e.Id = Convert.ToInt32(arr[0]);
            e.Name = arr[1];
            return e;
        }

        public virtual MCustomerEntity GetUpdateEntity(int id, string fullName)
        {
            var e = Entity;
            e.Id = id;
            e.Name = fullName;
            return e;
        }

        protected abstract MCustomerEntity Entity { get; }
    }
}
