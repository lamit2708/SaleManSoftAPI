using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.UCU.UserCustomer.Data.Db.Contexts;
using VSoft.Company.UCU.UserCustomer.Data.Entity.Models;

await new EfcSingleMigrateServiceMySQL<UserCustomerDbContext, MUserCustomerEntity>().LogCount();
