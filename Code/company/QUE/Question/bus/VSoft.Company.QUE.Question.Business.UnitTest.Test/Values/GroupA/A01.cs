using VSoft.Company.QUE.Question.Business.Dto.Data;
using VSoft.Company.QUE.Question.Business.UnitTest.Bases;

namespace VSoft.Company.QUE.Question.Business.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override QuestionDto Dto => new QuestionDto()
        {
            Id = 1   
        };
    }
}
