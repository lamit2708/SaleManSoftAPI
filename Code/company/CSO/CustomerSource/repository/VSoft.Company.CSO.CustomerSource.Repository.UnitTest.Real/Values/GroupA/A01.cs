using VSoft.Company.CSO.CustomerSource.Data.Entity.Models;
using VSoft.Company.CSO.CustomerSource.Repository.UnitTest.Bases;

namespace VSoft.Company.CSO.CustomerSource.Repository.UnitTest.Real.Values.GroupA
{
    public class A01 : TestEntity
    {
        protected override MCustomerSourceEntity Entity => new MCustomerSourceEntity()
        {
            //Id = 63452,
          
            Name = "Đặng Thế Nhân",
           
        };
    }
}
