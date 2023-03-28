using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.TEA.Team.Data.Db.Contexts;
using VSoft.Company.TEA.Team.Data.Entity.Models;
using VSoft.Company.TEA.Team.Repository.Services;

namespace VSoft.Company.TEA.Team.Repository.Efc.Services;

public interface ITeamRepositoryEfc : ITeamRepository, IEfcRepositoryEntityMgmtId<TeamDbContext, MTeamEntity, int>
{
   
}
