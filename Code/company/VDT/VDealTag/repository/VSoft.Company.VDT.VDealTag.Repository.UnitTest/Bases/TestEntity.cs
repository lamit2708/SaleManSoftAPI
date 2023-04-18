using VSoft.Company.VDT.VDealTag.Data.Entity.Models;

namespace VSoft.Company.VDT.VDealTag.Repository.UnitTest.Bases
{
    public abstract class TestEntity
    {
        public virtual MVDealTagEntity GetCreateEntity()
        {
            var e = Entity;

            return e;
        }

        public virtual MVDealTagEntity GetCreateEntity(string fullName)
        {
            var e = Entity;
            e.CustomerName = fullName;
            return e;
        }

        public virtual MVDealTagEntity GetUpdateEntity(int id)
        {
            var e = Entity;
            e.Id = id;
            return e;
        }

        public virtual MVDealTagEntity GetUpdateEntityFromData(string data)
        {
            var e = Entity;
            var arr = data.Split(" / ");
            e.Id = Convert.ToInt32(arr[0]);
            e.CustomerName = arr[1];
            return e;
        }

        public virtual MVDealTagEntity GetUpdateEntity(int id, string fullName)
        {
            var e = Entity;
            e.Id = id;
            e.CustomerName = fullName;
            return e;
        }

        protected abstract MVDealTagEntity Entity { get; }
    }
}
