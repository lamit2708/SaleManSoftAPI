using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.CSO.CustomerSource.Data.Db.Contexts;
using VSoft.Company.CSO.CustomerSource.Data.Entity.Models;
await new EfcSingleMigrateServiceMySQL<CustomerSourceDbContext, MCustomerSourceEntity>().LogCount();