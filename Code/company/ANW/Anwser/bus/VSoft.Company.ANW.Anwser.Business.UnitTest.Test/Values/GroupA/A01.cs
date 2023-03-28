using VSoft.Company.ANW.Anwser.Business.Dto.Data;
using VSoft.Company.ANW.Anwser.Business.UnitTest.Bases;

namespace VSoft.Company.ANW.Anwser.Business.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override AnwserDto Dto => new AnwserDto()
        {
            QuestionId = 1,
        };
    }
}
