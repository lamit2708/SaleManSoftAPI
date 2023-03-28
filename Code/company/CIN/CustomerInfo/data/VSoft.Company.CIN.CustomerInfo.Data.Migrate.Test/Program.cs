using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Efc.Migrate.Provider.Sqlite.Services;
using VSoft.Company.CIN.CustomerInfo.Data.Db.Contexts;
using VSoft.Company.CIN.CustomerInfo.Data.Entity.Models;
await new EfcSingleMigrateServiceSqlite<CustomerInfoDbContext, MCustomerInfoEntity>().LogCustom(async (dbContext) => {
    var list = dbContext.Items.Where(x => x.CustomerSourceId == 1).Select(p => new MCustomerInfoEntityBasic {Id = p.Id, CustomerSourceId = p.CustomerSourceId }).ToList();
    list.ForEach(data =>
    {
        if (data != null)
        {
            Console.WriteLine($"--------------------------");
            Console.WriteLine($"Id : {data.Id}");
            Console.WriteLine($"CustomerSourceId : {data.CustomerSourceId}");
        }
    });
    Console.WriteLine($"=========================");

    var fullName =  await dbContext.Items.Where(x => x.Id == 1).Select(p => p.CustomerSourceId).FirstOrDefaultAsync();
    Console.WriteLine($"CustomerSourceId : {fullName}");
});