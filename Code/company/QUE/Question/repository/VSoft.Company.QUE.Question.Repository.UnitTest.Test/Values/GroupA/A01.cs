using VSoft.Company.QUE.Question.Data.Entity.Models;
using VSoft.Company.QUE.Question.Repository.UnitTest.Bases;

namespace VSoft.Company.QUE.Question.Repository.UnitTest.Test.Values.GroupA
{
    public class A01 : TestEntity
    {
        protected override MQuestionEntity Entity => new MQuestionEntity()
        {
            Id = 1,
        };
    }
}
