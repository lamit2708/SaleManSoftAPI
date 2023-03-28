using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.PRI.Priority.Data.Db.Contexts;
using VSoft.Company.PRI.Priority.Data.Entity.Models;
using VSoft.Company.PRI.Priority.Repository.Services;

namespace VSoft.Company.PRI.Priority.Repository.Efc.Services;

public interface IPriorityRepositoryEfc : IPriorityRepository, IEfcRepositoryEntityMgmtId<PriorityDbContext, MPriorityEntity, int>
{
   
}
