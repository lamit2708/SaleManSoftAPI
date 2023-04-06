using VSoft.Company.DEA.Deal.Business.Dto.Data;
using VSoft.Company.DEA.Deal.Client.UnitTest.Bases;

namespace VSoft.Company.DEA.Deal.Client.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override DealDto Dto => new DealDto()
        {
           
            Name = "Đặng Thế Nhân",
          
            CreatedDate = DateTime.Now,

        };
    }
}
