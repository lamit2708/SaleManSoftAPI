using VSoft.Company.DQU.DealQuotation.Data.Entity.Models;

namespace VSoft.Company.DQU.DealQuotation.Repository.UnitTest.Bases
{
    public abstract class TestEntity
    {
        public virtual MDealQuotationEntity GetCreateEntity()
        {
            var e = Entity;

            return e;
        }

        public virtual MDealQuotationEntity GetCreateEntity(string fullName)
        {
            var e = Entity;
            //e.Name = fullName;
            return e;
        }

        public virtual MDealQuotationEntity GetUpdateEntity(int id)
        {
            var e = Entity;
            e.Id = id;
            return e;
        }

        public virtual MDealQuotationEntity GetUpdateEntityFromData(string data)
        {
            var e = Entity;
            var arr = data.Split(" / ");
            e.Id = Convert.ToInt32(arr[0]);
            //e.Name = arr[1];
            return e;
        }

        public virtual MDealQuotationEntity GetUpdateEntity(int id, string fullName)
        {
            var e = Entity;
            e.Id = id;
            //e.Name = fullName;
            return e;
        }

        protected abstract MDealQuotationEntity Entity { get; }
    }
}
