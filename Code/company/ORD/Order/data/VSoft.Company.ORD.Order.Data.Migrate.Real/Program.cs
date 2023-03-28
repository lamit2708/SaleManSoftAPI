using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.ORD.Order.Data.Db.Contexts;
using VSoft.Company.ORD.Order.Data.Entity.Models;
await new EfcSingleMigrateServiceMySQL<OrderDbContext, MOrderEntity>().LogCount();