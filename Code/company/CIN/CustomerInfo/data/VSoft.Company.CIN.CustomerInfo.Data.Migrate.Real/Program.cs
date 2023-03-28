using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.CIN.CustomerInfo.Data.Db.Contexts;
using VSoft.Company.CIN.CustomerInfo.Data.Entity.Models;
await new EfcSingleMigrateServiceMySQL<CustomerInfoDbContext, MCustomerInfoEntity>().LogCount();