using VSoft.Company.PRO.Product.Data.Entity.Models;
using VSoft.Company.PRO.Product.Repository.UnitTest.Bases;

namespace VSoft.Company.PRO.Product.Repository.UnitTest.Test.Values.GroupA
{
    public class A01 : TestEntity
    {
        protected override MProductEntity Entity => new MProductEntity()
        {
            //Id = 63452,
           
            Name = "Đặng Thế Nhân",
         
        };
    }
}
