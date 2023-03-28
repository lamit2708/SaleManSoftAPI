using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.ROL.Role.Data.Db.Contexts;
using VSoft.Company.ROL.Role.Data.Entity.Models;
using VSoft.Company.ROL.Role.Repository.Services;

namespace VSoft.Company.ROL.Role.Repository.Efc.Services;

public interface IRoleRepositoryEfc : IRoleRepository, IEfcRepositoryEntityMgmtId<RoleDbContext, MRoleEntity, int>
{
   
}
