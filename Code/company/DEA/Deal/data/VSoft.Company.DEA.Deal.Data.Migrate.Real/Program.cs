using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.DEA.Deal.Data.Db.Contexts;
using VSoft.Company.DEA.Deal.Data.Entity.Models;
await new EfcSingleMigrateServiceMySQL<DealDbContext, MDealEntity>().LogCount();