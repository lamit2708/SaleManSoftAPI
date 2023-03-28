using VSoft.Company.DQU.DealQuotation.Business.Dto.Data;
using VSoft.Company.DQU.DealQuotation.Business.UnitTest.Bases;

namespace VSoft.Company.DQU.DealQuotation.Business.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override DealQuotationDto Dto => new DealQuotationDto()
        {
            Id = 1
        };
    }
}
