using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Efc.Migrate.Provider.Sqlite.Services;
using VSoft.Company.POR.ProductOrder.Data.Db.Contexts;
using VSoft.Company.POR.ProductOrder.Data.Entity.Models;
await new EfcSingleMigrateServiceSqlite<ProductOrderDbContext, MProductOrderEntity>().LogCustom(async (dbContext) => {
    var list = dbContext.Items.Where(x => x.OrderId == 1).Select(p => new MProductOrderEntityBasic {Id = p.Id, ProductId = p.ProductId }).ToList();
    list.ForEach(data =>
    {
        if (data != null)
        {
            Console.WriteLine($"--------------------------");
            Console.WriteLine($"Id : {data.Id}");
            Console.WriteLine($"Order Id : {data.OrderId}");
        }
    });
    Console.WriteLine($"=========================");

    var fullName =  await dbContext.Items.Where(x => x.Id == 1).Select(p => p.OrderId).FirstOrDefaultAsync();
    Console.WriteLine($"FullName : {fullName}");
});