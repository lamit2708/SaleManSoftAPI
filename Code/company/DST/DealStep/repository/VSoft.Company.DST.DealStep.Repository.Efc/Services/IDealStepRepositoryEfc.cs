using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.DST.DealStep.Data.Db.Contexts;
using VSoft.Company.DST.DealStep.Data.Entity.Models;
using VSoft.Company.DST.DealStep.Repository.Services;

namespace VSoft.Company.DST.DealStep.Repository.Efc.Services;

public interface IDealStepRepositoryEfc : IDealStepRepository, IEfcRepositoryEntityMgmtId<DealStepDbContext, MDealStepEntity, int>
{
   
}
