using VSoft.Company.USR.User.Data.Entity.Models;
using VSoft.Company.USR.User.Repository.UnitTest.Bases;

namespace VSoft.Company.USR.User.Repository.UnitTest.Test.Values.GroupA
{
    public class A01 : TestEntity
    {
        protected override MUserEntity Entity => new MUserEntity()
        {
            //Id = 63452,
           
            Name = "Đặng Thế Nhân",
         
        };
    }
}
