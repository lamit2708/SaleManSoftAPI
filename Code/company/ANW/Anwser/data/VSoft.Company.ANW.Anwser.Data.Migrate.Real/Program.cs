using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.ANW.Anwser.Data.Db.Contexts;
using VSoft.Company.ANW.Anwser.Data.Entity.Models;
await new EfcSingleMigrateServiceMySQL<AnwserDbContext, MAnwserEntity>().LogCount();