using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.USR.User.Data.Db.Contexts;
using VSoft.Company.USR.User.Data.Entity.Models;

namespace VSoft.Company.USR.User.Repository.Services;

public interface IUserRepository : IEfcRepositoryEntityMgmtId<UserDbContext, MUserEntity, int>
{

    string? GetFullName(int? id);

    Task<string?> GetFullNameAsync(int? id);
}
