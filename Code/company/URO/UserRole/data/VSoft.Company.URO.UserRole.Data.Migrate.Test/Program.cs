using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Efc.Migrate.Provider.Sqlite.Services;
using VSoft.Company.URO.UserRole.Data.Db.Contexts;
using VSoft.Company.URO.UserRole.Data.Entity.Models;
await new EfcSingleMigrateServiceSqlite<UserRoleDbContext, MUserRoleEntity>().LogCustom(async (dbContext) => {
    var list = dbContext.Items.Where(x => x.Id == 1).Select(p => new MUserRoleEntityBasic {Id = p.Id, UserId = p.UserId }).ToList();
    list.ForEach(data =>
    {
        if (data != null)
        {
            Console.WriteLine($"--------------------------");
            Console.WriteLine($"Id : {data.Id}");
            Console.WriteLine($"UserId : {data.UserId}");
        }
    });
    Console.WriteLine($"=========================");

    var fullName =  await dbContext.Items.Where(x => x.Id == 1).Select(p => p.UserId).FirstOrDefaultAsync();
    Console.WriteLine($"UserId : {fullName}");
});