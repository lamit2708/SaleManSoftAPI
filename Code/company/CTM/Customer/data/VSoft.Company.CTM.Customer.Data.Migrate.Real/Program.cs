using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.CTM.Customer.Data.Db.Contexts;
using VSoft.Company.CTM.Customer.Data.Entity.Models;
await new EfcSingleMigrateServiceMySQL<CustomerDbContext, MCustomerEntity>().LogCount();