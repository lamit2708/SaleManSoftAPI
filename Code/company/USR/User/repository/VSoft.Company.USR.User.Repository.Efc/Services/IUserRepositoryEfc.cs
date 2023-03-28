using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.USR.User.Data.Db.Contexts;
using VSoft.Company.USR.User.Data.Entity.Models;
using VSoft.Company.USR.User.Repository.Services;

namespace VSoft.Company.USR.User.Repository.Efc.Services;

public interface IUserRepositoryEfc : IUserRepository, IEfcRepositoryEntityMgmtId<UserDbContext, MUserEntity, int>
{
   
}
