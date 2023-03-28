using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.USR.User.Data.Db.Contexts;
using VSoft.Company.USR.User.Data.Entity.Models;
await new EfcSingleMigrateServiceMySQL<UserDbContext, MUserEntity>().LogCount();