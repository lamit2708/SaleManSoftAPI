using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.QUE.Question.Data.Db.Contexts;
using VSoft.Company.QUE.Question.Data.Entity.Models;
using VSoft.Company.QUE.Question.Repository.Services;

namespace VSoft.Company.QUE.Question.Repository.Efc.Services;

public interface IQuestionRepositoryEfc : IQuestionRepository, IEfcRepositoryEntityMgmtId<QuestionDbContext, MQuestionEntity, long>
{
   
}
