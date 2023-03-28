using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Repository.Id.Efc.Provider.Services;
using VSoft.Company.DSH.DealStepHistory.Data.Db.Contexts;
using VSoft.Company.DSH.DealStepHistory.Data.Entity.Models;
using VSoft.Company.DSH.DealStepHistory.Repository.Efc.Services;

namespace VSoft.Company.DSH.DealStepHistory.Repository.Efc.Provider.Services;

public class EfcDealStepHistoryRepository : EFcRepositoryEntityMgmtId<DealStepHistoryDbContext, MDealStepHistoryEntity, long>, IDealStepHistoryRepositoryEfc
{

    public EfcDealStepHistoryRepository(DealStepHistoryDbContext dbContext) : base(dbContext, dbContext.Items)
    {

    }

    public string? GetFullName(long? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.DealStepId.ToString() ?? string.Empty).FirstOrDefault();
    }

    public Task<string?> GetFullNameAsync(long? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.DealStepId.ToString() ?? string.Empty).FirstOrDefaultAsync() ;
    }
}
