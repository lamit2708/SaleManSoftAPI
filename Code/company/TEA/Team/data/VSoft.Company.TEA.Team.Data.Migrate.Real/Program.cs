using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.TEA.Team.Data.Db.Contexts;
using VSoft.Company.TEA.Team.Data.Entity.Models;
await new EfcSingleMigrateServiceMySQL<TeamDbContext, MTeamEntity>().LogCount();