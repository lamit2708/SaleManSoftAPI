using VSoft.Company.DSH.DealStepHistory.Data.Entity.Models;

namespace VSoft.Company.DSH.DealStepHistory.Repository.UnitTest.Bases
{
    public abstract class TestEntity
    {
        public virtual MDealStepHistoryEntity GetCreateEntity()
        {
            var e = Entity;

            return e;
        }

        public virtual MDealStepHistoryEntity GetCreateEntity(string fullName)
        {
            var e = Entity;
            //e.Name = fullName;
            return e;
        }

        public virtual MDealStepHistoryEntity GetUpdateEntity(int id)
        {
            var e = Entity;
            e.Id = id;
            return e;
        }

        public virtual MDealStepHistoryEntity GetUpdateEntityFromData(string data)
        {
            var e = Entity;
            var arr = data.Split(" / ");
            e.Id = Convert.ToInt32(arr[0]);
            //e.Name = arr[1];
            return e;
        }

        public virtual MDealStepHistoryEntity GetUpdateEntity(int id, string fullName)
        {
            var e = Entity;
            e.Id = id;
            //e.Name = fullName;
            return e;
        }

        protected abstract MDealStepHistoryEntity Entity { get; }
    }
}
