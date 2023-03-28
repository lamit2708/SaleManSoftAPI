using VSoft.Company.DST.DealStep.Business.Dto.Data;
using VSoft.Company.DST.DealStep.Client.UnitTest.Bases;

namespace VSoft.Company.DST.DealStep.Client.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override DealStepDto Dto => new DealStepDto()
        {
           
            FullName = "Đặng Thế Nhân",
          
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,

        };
    }
}
