using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.PRO.Product.Data.Db.Contexts;
using VSoft.Company.PRO.Product.Data.Entity.Models;
await new EfcSingleMigrateServiceMySQL<ProductDbContext, MProductEntity>().LogCount();