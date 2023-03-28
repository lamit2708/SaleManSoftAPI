using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.DSH.DealStepHistory.Data.Db.Contexts;
using VSoft.Company.DSH.DealStepHistory.Data.Entity.Models;

namespace VSoft.Company.DSH.DealStepHistory.Repository.Services;

public interface IDealStepHistoryRepository : IEfcRepositoryEntityMgmtId<DealStepHistoryDbContext, MDealStepHistoryEntity, long>
{

    string? GetFullName(long? id);

    Task<string?> GetFullNameAsync(long? id);
}
