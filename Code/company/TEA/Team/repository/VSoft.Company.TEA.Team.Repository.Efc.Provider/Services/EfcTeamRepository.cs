using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Repository.Id.Efc.Provider.Services;
using VSoft.Company.TEA.Team.Data.Db.Contexts;
using VSoft.Company.TEA.Team.Data.Entity.Models;
using VSoft.Company.TEA.Team.Repository.Efc.Services;

namespace VSoft.Company.TEA.Team.Repository.Efc.Provider.Services;

public class EfcTeamRepository : EFcRepositoryEntityMgmtId<TeamDbContext, MTeamEntity, int>, ITeamRepositoryEfc
{

    public EfcTeamRepository(TeamDbContext dbContext) : base(dbContext, dbContext.Items)
    {

    }

    public string? GetFullName(int? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.Name ?? string.Empty).FirstOrDefault();
    }

    public Task<string?> GetFullNameAsync(int? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.Name ?? string.Empty).FirstOrDefaultAsync() ;
    }
}
