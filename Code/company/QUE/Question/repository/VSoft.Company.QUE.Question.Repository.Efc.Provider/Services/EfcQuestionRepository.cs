using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Repository.Id.Efc.Provider.Services;
using VSoft.Company.QUE.Question.Data.Db.Contexts;
using VSoft.Company.QUE.Question.Data.Entity.Models;
using VSoft.Company.QUE.Question.Repository.Efc.Services;

namespace VSoft.Company.QUE.Question.Repository.Efc.Provider.Services;

public class EfcQuestionRepository : EFcRepositoryEntityMgmtId<QuestionDbContext, MQuestionEntity, long>, IQuestionRepositoryEfc
{

    public EfcQuestionRepository(QuestionDbContext dbContext) : base(dbContext, dbContext.Items)
    {

    }

    public string? GetFullName(long? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.TicketId.ToString() ?? string.Empty).FirstOrDefault();
    }

    public Task<string?> GetFullNameAsync(long? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.TicketId.ToString() ?? string.Empty).FirstOrDefaultAsync() ;
    }
}
