using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Efc.Migrate.Provider.Sqlite.Services;
using VSoft.Company.VDT.VDealTag.Data.Db.Contexts;
using VSoft.Company.VDT.VDealTag.Data.Entity.Models;
await new EfcSingleMigrateServiceSqlite<VDealTagDbContext, MVDealTagEntity>().LogCustom(async (dbContext) => {
    var list = dbContext.Items.Where(x => x.CustomerName == "Đặng Thế Nhân").Select(p => new MVDealTagEntityBasic {Id = p.Id, CustomerName = p.CustomerName }).ToList();
    list.ForEach(data =>
    {
        if (data != null)
        {
            Console.WriteLine($"--------------------------");
            Console.WriteLine($"Id : {data.Id}");
            Console.WriteLine($"FullName : {data.CustomerName}");
        }
    });
    Console.WriteLine($"=========================");

    var fullName =  await dbContext.Items.Where(x => x.Id == 1).Select(p => p.CustomerName).FirstOrDefaultAsync();
    Console.WriteLine($"FullName : {fullName}");
});