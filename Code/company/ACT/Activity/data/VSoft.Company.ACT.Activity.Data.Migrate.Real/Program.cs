using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.ACT.Activity.Data.Db.Contexts;
using VSoft.Company.ACT.Activity.Data.Entity.Models;
await new EfcSingleMigrateServiceMySQL<ActivityDbContext, MActivityEntity>().LogCount();