using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.PRC.ProductCategory.Data.Db.Contexts;
using VSoft.Company.PRC.ProductCategory.Data.Entity.Models;
await new EfcSingleMigrateServiceMySQL<ProductCategoryDbContext, MProductCategoryEntity>().LogCount();