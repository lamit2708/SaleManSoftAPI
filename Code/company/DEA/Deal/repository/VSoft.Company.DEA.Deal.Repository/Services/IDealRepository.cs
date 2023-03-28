using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.DEA.Deal.Data.Db.Contexts;
using VSoft.Company.DEA.Deal.Data.Entity.Models;

namespace VSoft.Company.DEA.Deal.Repository.Services;

public interface IDealRepository : IEfcRepositoryEntityMgmtId<DealDbContext, MDealEntity, long>
{

    string? GetFullName(long? id);

    Task<string?> GetFullNameAsync(long? id);
}
