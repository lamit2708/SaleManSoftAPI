using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.CTM.Main.Data.Db.Contexts;
using VSoft.Company.CTM.Main.Data.Entity.Models;
await new EfcSingleMigrateServiceMySQL<MainDbContext, MMainEntity>().LogCount();