using VSoft.Company.DSH.DealStepHistory.Business.Dto.Data;
using VSoft.Company.DSH.DealStepHistory.Business.UnitTest.Bases;

namespace VSoft.Company.DSH.DealStepHistory.Business.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override DealStepHistoryDto Dto => new DealStepHistoryDto()
        {
            Id = 1   
        };
    }
}
