using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.CSO.CustomerSource.Data.Db.Contexts;
using VSoft.Company.CSO.CustomerSource.Data.Entity.Models;

namespace VSoft.Company.CSO.CustomerSource.Repository.Services;

public interface ICustomerSourceRepository : IEfcRepositoryEntityMgmtId<CustomerSourceDbContext, MCustomerSourceEntity, int>
{

    string? GetFullName(int? id);

    Task<string?> GetFullNameAsync(int? id);
}
