using VSoft.Company.PRC.ProductCategory.Data.Entity.Models;
using VSoft.Company.PRC.ProductCategory.Repository.UnitTest.Bases;

namespace VSoft.Company.PRC.ProductCategory.Repository.UnitTest.Real.Values.GroupA
{
    public class A01 : TestEntity
    {
        protected override MProductCategoryEntity Entity => new MProductCategoryEntity()
        {
            //Id = 63452,

            Name = "Đặng Thế Nhân",

        };
    }
}
