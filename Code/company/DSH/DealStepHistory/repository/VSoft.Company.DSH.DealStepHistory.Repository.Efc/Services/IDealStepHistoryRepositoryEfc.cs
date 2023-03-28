using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.DSH.DealStepHistory.Data.Db.Contexts;
using VSoft.Company.DSH.DealStepHistory.Data.Entity.Models;
using VSoft.Company.DSH.DealStepHistory.Repository.Services;

namespace VSoft.Company.DSH.DealStepHistory.Repository.Efc.Services;

public interface IDealStepHistoryRepositoryEfc : IDealStepHistoryRepository, IEfcRepositoryEntityMgmtId<DealStepHistoryDbContext, MDealStepHistoryEntity, long>
{
   
}
