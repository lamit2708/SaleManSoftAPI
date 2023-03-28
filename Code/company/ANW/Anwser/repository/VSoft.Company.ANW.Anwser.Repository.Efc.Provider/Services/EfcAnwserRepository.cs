using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Repository.Id.Efc.Provider.Services;
using VSoft.Company.ANW.Anwser.Data.Db.Contexts;
using VSoft.Company.ANW.Anwser.Data.Entity.Models;
using VSoft.Company.ANW.Anwser.Repository.Efc.Services;

namespace VSoft.Company.ANW.Anwser.Repository.Efc.Provider.Services;

public class EfcAnwserRepository : EFcRepositoryEntityMgmtId<AnwserDbContext, MAnwserEntity, long>, IAnwserRepositoryEfc
{

    public EfcAnwserRepository(AnwserDbContext dbContext) : base(dbContext, dbContext.Items)
    {

    }

    public string? GetFullName(long? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.QuestionId.ToString() ?? string.Empty).FirstOrDefault();
    }

    public Task<string?> GetFullNameAsync(long? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.QuestionId.ToString() ?? string.Empty).FirstOrDefaultAsync() ;
    }
}
