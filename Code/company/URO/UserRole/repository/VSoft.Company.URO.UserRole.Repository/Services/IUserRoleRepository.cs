using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.URO.UserRole.Data.Db.Contexts;
using VSoft.Company.URO.UserRole.Data.Entity.Models;

namespace VSoft.Company.URO.UserRole.Repository.Services;

public interface IUserRoleRepository : IEfcRepositoryEntityMgmtId<UserRoleDbContext, MUserRoleEntity, long>
{

    string? GetFullName(long? id);

    Task<string?> GetFullNameAsync(long? id);
}
