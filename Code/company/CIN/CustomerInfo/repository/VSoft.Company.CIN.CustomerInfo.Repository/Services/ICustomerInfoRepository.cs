using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.CIN.CustomerInfo.Data.Db.Contexts;
using VSoft.Company.CIN.CustomerInfo.Data.Entity.Models;

namespace VSoft.Company.CIN.CustomerInfo.Repository.Services;

public interface ICustomerInfoRepository : IEfcRepositoryEntityMgmtId<CustomerInfoDbContext, MCustomerInfoEntity, long>
{

    string? GetFullName(long? id);

    Task<string?> GetFullNameAsync(long? id);
}
