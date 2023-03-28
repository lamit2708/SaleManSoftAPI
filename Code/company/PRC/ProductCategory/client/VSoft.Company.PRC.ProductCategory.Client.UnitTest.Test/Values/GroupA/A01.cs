using VSoft.Company.PRC.ProductCategory.Business.Dto.Data;
using VSoft.Company.PRC.ProductCategory.Client.UnitTest.Bases;

namespace VSoft.Company.PRC.ProductCategory.Client.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override ProductCategoryDto Dto => new ProductCategoryDto()
        {

            FullName = "Đặng Thế Nhân",

            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,

        };
    }
}
