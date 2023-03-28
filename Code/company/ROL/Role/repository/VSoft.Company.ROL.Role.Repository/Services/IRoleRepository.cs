using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.ROL.Role.Data.Db.Contexts;
using VSoft.Company.ROL.Role.Data.Entity.Models;

namespace VSoft.Company.ROL.Role.Repository.Services;

public interface IRoleRepository : IEfcRepositoryEntityMgmtId<RoleDbContext, MRoleEntity, int>
{

    string? GetFullName(int? id);

    Task<string?> GetFullNameAsync(int? id);
}
