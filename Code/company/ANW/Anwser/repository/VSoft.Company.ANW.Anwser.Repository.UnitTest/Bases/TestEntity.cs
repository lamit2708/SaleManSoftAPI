using VSoft.Company.ANW.Anwser.Data.Entity.Models;

namespace VSoft.Company.ANW.Anwser.Repository.UnitTest.Bases
{
    public abstract class TestEntity
    {
        public virtual MAnwserEntity GetCreateEntity()
        {
            var e = Entity;

            return e;
        }

        public virtual MAnwserEntity GetCreateEntity(string fullName)
        {
            var e = Entity;
            //e.Name = fullName;
            return e;
        }

        public virtual MAnwserEntity GetUpdateEntity(int id)
        {
            var e = Entity;
            e.Id = id;
            return e;
        }

        public virtual MAnwserEntity GetUpdateEntityFromData(string data)
        {
            var e = Entity;
            var arr = data.Split(" / ");
            e.Id = Convert.ToInt32(arr[0]);
            //e.Name = arr[1];
            return e;
        }

        public virtual MAnwserEntity GetUpdateEntity(int id, string fullName)
        {
            var e = Entity;
            e.Id = id;
            //e.Name = fullName;
            return e;
        }

        protected abstract MAnwserEntity Entity { get; }
    }
}
