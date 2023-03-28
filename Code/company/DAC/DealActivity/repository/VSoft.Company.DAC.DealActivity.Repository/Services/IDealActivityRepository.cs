using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.DAC.DealActivity.Data.Db.Contexts;
using VSoft.Company.DAC.DealActivity.Data.Entity.Models;

namespace VSoft.Company.DAC.DealActivity.Repository.Services;

public interface IDealActivityRepository : IEfcRepositoryEntityMgmtId<DealActivityDbContext, MDealActivityEntity, int>
{

    string? GetFullName(int? id);

    Task<string?> GetFullNameAsync(int? id);
}
