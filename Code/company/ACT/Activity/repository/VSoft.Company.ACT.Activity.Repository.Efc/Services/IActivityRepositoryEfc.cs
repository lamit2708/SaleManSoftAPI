using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.ACT.Activity.Data.Db.Contexts;
using VSoft.Company.ACT.Activity.Data.Entity.Models;
using VSoft.Company.ACT.Activity.Repository.Services;

namespace VSoft.Company.ACT.Activity.Repository.Efc.Services;

public interface IActivityRepositoryEfc : IActivityRepository, IEfcRepositoryEntityMgmtId<ActivityDbContext, MActivityEntity, int>
{
   
}
