using VSoft.Company.ACT.Activity.Business.Dto.Data;
using VSoft.Company.ACT.Activity.Business.UnitTest.Bases;

namespace VSoft.Company.ACT.Activity.Business.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override ActivityDto Dto => new ActivityDto()
        {
            Id = 1
        };
    }
}
