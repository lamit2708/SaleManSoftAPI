using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Repository.Id.Efc.Provider.Services;
using VSoft.Company.CIN.CustomerInfo.Data.Db.Contexts;
using VSoft.Company.CIN.CustomerInfo.Data.Entity.Models;
using VSoft.Company.CIN.CustomerInfo.Repository.Efc.Services;

namespace VSoft.Company.CIN.CustomerInfo.Repository.Efc.Provider.Services;

public class EfcCustomerInfoRepository : EFcRepositoryEntityMgmtId<CustomerInfoDbContext, MCustomerInfoEntity, long>, ICustomerInfoRepositoryEfc
{

    public EfcCustomerInfoRepository(CustomerInfoDbContext dbContext) : base(dbContext, dbContext.Items)
    {

    }

    public string? GetFullName(long? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.CustomerSourceId.ToString() ?? string.Empty).FirstOrDefault();
    }

    public Task<string?> GetFullNameAsync(long? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.CustomerSourceId.ToString() ?? string.Empty).FirstOrDefaultAsync() ;
    }
}
