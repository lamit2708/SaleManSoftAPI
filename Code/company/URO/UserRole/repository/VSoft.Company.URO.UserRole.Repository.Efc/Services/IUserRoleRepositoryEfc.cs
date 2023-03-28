using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.URO.UserRole.Data.Db.Contexts;
using VSoft.Company.URO.UserRole.Data.Entity.Models;
using VSoft.Company.URO.UserRole.Repository.Services;

namespace VSoft.Company.URO.UserRole.Repository.Efc.Services;

public interface IUserRoleRepositoryEfc : IUserRoleRepository, IEfcRepositoryEntityMgmtId<UserRoleDbContext, MUserRoleEntity, long>
{
   
}
