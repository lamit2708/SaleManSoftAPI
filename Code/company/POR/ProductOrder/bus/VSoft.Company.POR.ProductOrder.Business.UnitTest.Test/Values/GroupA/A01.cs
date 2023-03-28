using VSoft.Company.POR.ProductOrder.Business.Dto.Data;
using VSoft.Company.POR.ProductOrder.Business.UnitTest.Bases;

namespace VSoft.Company.POR.ProductOrder.Business.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override ProductOrderDto Dto => new ProductOrderDto()
        {
         
            //Name = "Đặng Thế Nhân",
            Id = 1
        };
    }
}
