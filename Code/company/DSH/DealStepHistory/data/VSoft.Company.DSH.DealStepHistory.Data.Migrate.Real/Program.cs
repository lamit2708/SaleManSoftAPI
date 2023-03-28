using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.DSH.DealStepHistory.Data.Db.Contexts;
using VSoft.Company.DSH.DealStepHistory.Data.Entity.Models;
await new EfcSingleMigrateServiceMySQL<DealStepHistoryDbContext, MDealStepHistoryEntity>().LogCount();