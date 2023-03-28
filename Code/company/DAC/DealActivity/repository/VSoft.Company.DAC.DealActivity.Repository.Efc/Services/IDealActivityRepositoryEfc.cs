using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.DAC.DealActivity.Data.Db.Contexts;
using VSoft.Company.DAC.DealActivity.Data.Entity.Models;
using VSoft.Company.DAC.DealActivity.Repository.Services;

namespace VSoft.Company.DAC.DealActivity.Repository.Efc.Services;

public interface IDealActivityRepositoryEfc : IDealActivityRepository, IEfcRepositoryEntityMgmtId<DealActivityDbContext, MDealActivityEntity, int>
{
   
}
