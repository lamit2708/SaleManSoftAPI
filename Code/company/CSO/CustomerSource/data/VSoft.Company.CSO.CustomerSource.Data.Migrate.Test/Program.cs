using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Efc.Migrate.Provider.Sqlite.Services;
using VSoft.Company.CSO.CustomerSource.Data.Db.Contexts;
using VSoft.Company.CSO.CustomerSource.Data.Entity.Models;
await new EfcSingleMigrateServiceSqlite<CustomerSourceDbContext, MCustomerSourceEntity>().LogCustom(async (dbContext) => {
    var list = dbContext.Items.Where(x => x.Name == "Đặng Thế Nhân").Select(p => new MCustomerSourceEntityBasic {Id = p.Id, Name = p.Name }).ToList();
    list.ForEach(data =>
    {
        if (data != null)
        {
            Console.WriteLine($"--------------------------");
            Console.WriteLine($"Id : {data.Id}");
            Console.WriteLine($"FullName : {data.Name}");
        }
    });
    Console.WriteLine($"=========================");

    var fullName =  await dbContext.Items.Where(x => x.Id == 1).Select(p => p.Name).FirstOrDefaultAsync();
    Console.WriteLine($"FullName : {fullName}");
});