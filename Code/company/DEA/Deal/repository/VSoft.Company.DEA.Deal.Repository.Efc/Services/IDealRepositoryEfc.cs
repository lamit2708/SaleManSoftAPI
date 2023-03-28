using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.DEA.Deal.Data.Db.Contexts;
using VSoft.Company.DEA.Deal.Data.Entity.Models;
using VSoft.Company.DEA.Deal.Repository.Services;

namespace VSoft.Company.DEA.Deal.Repository.Efc.Services;

public interface IDealRepositoryEfc : IDealRepository, IEfcRepositoryEntityMgmtId<DealDbContext, MDealEntity, long>
{
   
}
