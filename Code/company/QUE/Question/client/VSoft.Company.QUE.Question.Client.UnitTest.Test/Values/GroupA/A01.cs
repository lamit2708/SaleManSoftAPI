using VSoft.Company.QUE.Question.Business.Dto.Data;
using VSoft.Company.QUE.Question.Client.UnitTest.Bases;

namespace VSoft.Company.QUE.Question.Client.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override QuestionDto Dto => new QuestionDto()
        {
           
            FullName = "Đặng Thế Nhân",
          
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,

        };
    }
}
