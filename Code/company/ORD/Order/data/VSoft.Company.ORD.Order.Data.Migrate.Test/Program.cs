using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Efc.Migrate.Provider.Sqlite.Services;
using VSoft.Company.ORD.Order.Data.Db.Contexts;
using VSoft.Company.ORD.Order.Data.Entity.Models;
await new EfcSingleMigrateServiceSqlite<OrderDbContext, MOrderEntity>().LogCustom(async (dbContext) => {
    var list = dbContext.Items.Where(x => x.Id == 1).Select(p => new MOrderEntityBasic {Id = p.Id, CustomerId = p.CustomerId }).ToList();
    list.ForEach(data =>
    {
        if (data != null)
        {
            Console.WriteLine($"--------------------------");
            Console.WriteLine($"Id : {data.Id}");
            Console.WriteLine($"CustomerId : {data.CustomerId}");
        }
    });
    Console.WriteLine($"=========================");

    var fullName =  await dbContext.Items.Where(x => x.Id == 1).Select(p => p.CustomerId).FirstOrDefaultAsync();
    Console.WriteLine($"FullName : {fullName}");
});