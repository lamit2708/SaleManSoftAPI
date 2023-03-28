using VSoft.Company.PRO.Product.Business.Dto.Data;
using VSoft.Company.PRO.Product.Client.UnitTest.Bases;

namespace VSoft.Company.PRO.Product.Client.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override ProductDto Dto => new ProductDto()
        {
           
            FullName = "Đặng Thế Nhân",
          
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,

        };
    }
}
