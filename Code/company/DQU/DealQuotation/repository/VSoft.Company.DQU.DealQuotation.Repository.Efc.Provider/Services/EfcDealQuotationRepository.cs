using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Repository.Id.Efc.Provider.Services;
using VSoft.Company.DQU.DealQuotation.Data.Db.Contexts;
using VSoft.Company.DQU.DealQuotation.Data.Entity.Models;
using VSoft.Company.DQU.DealQuotation.Repository.Efc.Services;

namespace VSoft.Company.DQU.DealQuotation.Repository.Efc.Provider.Services;

public class EfcDealQuotationRepository : EFcRepositoryEntityMgmtId<DealQuotationDbContext, MDealQuotationEntity, long>, IDealQuotationRepositoryEfc
{

    public EfcDealQuotationRepository(DealQuotationDbContext dbContext) : base(dbContext, dbContext.Items)
    {

    }

    public string? GetFullName(long? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.DealId.ToString() ?? string.Empty).FirstOrDefault();
    }

    public Task<string?> GetFullNameAsync(long? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.DealId.ToString() ?? string.Empty).FirstOrDefaultAsync() ;
    }
}
