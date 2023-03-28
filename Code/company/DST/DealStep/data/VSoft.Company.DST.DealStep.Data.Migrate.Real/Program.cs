using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.DST.DealStep.Data.Db.Contexts;
using VSoft.Company.DST.DealStep.Data.Entity.Models;
await new EfcSingleMigrateServiceMySQL<DealStepDbContext, MDealStepEntity>().LogCount();