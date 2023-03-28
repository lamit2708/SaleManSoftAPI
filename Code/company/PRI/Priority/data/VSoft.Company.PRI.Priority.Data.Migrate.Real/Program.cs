using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.PRI.Priority.Data.Db.Contexts;
using VSoft.Company.PRI.Priority.Data.Entity.Models;
await new EfcSingleMigrateServiceMySQL<PriorityDbContext, MPriorityEntity>().LogCount();