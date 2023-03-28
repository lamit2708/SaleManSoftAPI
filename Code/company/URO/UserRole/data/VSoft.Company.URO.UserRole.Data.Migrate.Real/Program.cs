using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.URO.UserRole.Data.Db.Contexts;
using VSoft.Company.URO.UserRole.Data.Entity.Models;
await new EfcSingleMigrateServiceMySQL<UserRoleDbContext, MUserRoleEntity>().LogCount();