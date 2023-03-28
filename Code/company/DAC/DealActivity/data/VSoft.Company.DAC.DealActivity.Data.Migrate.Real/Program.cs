using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.DAC.DealActivity.Data.Db.Contexts;
using VSoft.Company.DAC.DealActivity.Data.Entity.Models;
await new EfcSingleMigrateServiceMySQL<DealActivityDbContext, MDealActivityEntity>().LogCount();