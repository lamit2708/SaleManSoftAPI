using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.PRF.ProductFeature.Data.Db.Contexts;
using VSoft.Company.PRF.ProductFeature.Data.Entity.Models;
await new EfcSingleMigrateServiceMySQL<ProductFeatureDbContext, MProductFeatureEntity>().LogCount();