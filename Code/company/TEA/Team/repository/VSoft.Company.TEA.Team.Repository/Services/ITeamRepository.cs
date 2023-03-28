using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.TEA.Team.Data.Db.Contexts;
using VSoft.Company.TEA.Team.Data.Entity.Models;

namespace VSoft.Company.TEA.Team.Repository.Services;

public interface ITeamRepository : IEfcRepositoryEntityMgmtId<TeamDbContext, MTeamEntity, int>
{

    string? GetFullName(int? id);

    Task<string?> GetFullNameAsync(int? id);
}
