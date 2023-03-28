using VSoft.Company.CTM.Customer.Data.Entity.Models;
using VSoft.Company.CTM.Customer.Repository.UnitTest.Bases;

namespace VSoft.Company.CTM.Customer.Repository.UnitTest.Test.Values.GroupA
{
    public class A01 : TestEntity
    {
        protected override MCustomerEntity Entity => new MCustomerEntity()
        {
            //Id = 63452,
           
            Name = "Đặng Thế Nhân",
         
        };
    }
}
