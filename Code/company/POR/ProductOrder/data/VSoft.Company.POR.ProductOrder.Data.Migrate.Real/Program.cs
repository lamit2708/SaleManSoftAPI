using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.POR.ProductOrder.Data.Db.Contexts;
using VSoft.Company.POR.ProductOrder.Data.Entity.Models;
await new EfcSingleMigrateServiceMySQL<ProductOrderDbContext, MProductOrderEntity>().LogCount();