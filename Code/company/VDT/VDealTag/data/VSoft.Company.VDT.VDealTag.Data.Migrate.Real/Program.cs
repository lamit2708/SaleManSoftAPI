using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.VDT.VDealTag.Data.Db.Contexts;
using VSoft.Company.VDT.VDealTag.Data.Entity.Models;
await new EfcSingleMigrateServiceMySQL<VDealTagDbContext, MVDealTagEntity>().LogCount();