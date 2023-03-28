using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.DQU.DealQuotation.Data.Db.Contexts;
using VSoft.Company.DQU.DealQuotation.Data.Entity.Models;
await new EfcSingleMigrateServiceMySQL<DealQuotationDbContext, MDealQuotationEntity>().LogCount();