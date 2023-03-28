using VSoft.Company.DQU.DealQuotation.Business.Dto.Data;
using VSoft.Company.DQU.DealQuotation.Client.UnitTest.Bases;

namespace VSoft.Company.DQU.DealQuotation.Client.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override DealQuotationDto Dto => new DealQuotationDto()
        {
           
            FullName = "Đặng Thế Nhân",
          
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,

        };
    }
}
