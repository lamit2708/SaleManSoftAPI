using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.ROL.Role.Data.Db.Contexts;
using VSoft.Company.ROL.Role.Data.Entity.Models;
await new EfcSingleMigrateServiceMySQL<RoleDbContext, MRoleEntity>().LogCount();