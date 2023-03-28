using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Repository.Id.Efc.Provider.Services;
using VSoft.Company.URO.UserRole.Data.Db.Contexts;
using VSoft.Company.URO.UserRole.Data.Entity.Models;
using VSoft.Company.URO.UserRole.Repository.Efc.Services;

namespace VSoft.Company.URO.UserRole.Repository.Efc.Provider.Services;

public class EfcUserRoleRepository : EFcRepositoryEntityMgmtId<UserRoleDbContext, MUserRoleEntity, long>, IUserRoleRepositoryEfc
{

    public EfcUserRoleRepository(UserRoleDbContext dbContext) : base(dbContext, dbContext.Items)
    {

    }

    public string? GetFullName(long? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.UserId.ToString() ?? string.Empty).FirstOrDefault();
    }

    public Task<string?> GetFullNameAsync(long? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.UserId.ToString() ?? string.Empty).FirstOrDefaultAsync() ;
    }
}
