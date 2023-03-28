using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.QUE.Question.Data.Db.Contexts;
using VSoft.Company.QUE.Question.Data.Entity.Models;

namespace VSoft.Company.QUE.Question.Repository.Services;

public interface IQuestionRepository : IEfcRepositoryEntityMgmtId<QuestionDbContext, MQuestionEntity, long>
{

    string? GetFullName(long? id);

    Task<string?> GetFullNameAsync(long? id);
}
