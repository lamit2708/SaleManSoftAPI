using VSoft.Company.ORD.Order.Business.Dto.Data;
using VSoft.Company.ORD.Order.Client.UnitTest.Bases;

namespace VSoft.Company.ORD.Order.Client.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override OrderDto Dto => new OrderDto()
        {
           
            FullName = "Đặng Thế Nhân",
          
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,

        };
    }
}
