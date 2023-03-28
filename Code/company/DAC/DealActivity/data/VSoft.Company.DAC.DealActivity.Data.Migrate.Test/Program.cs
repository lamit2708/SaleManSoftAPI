using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Efc.Migrate.Provider.Sqlite.Services;
using VSoft.Company.DAC.DealActivity.Data.Db.Contexts;
using VSoft.Company.DAC.DealActivity.Data.Entity.Models;
await new EfcSingleMigrateServiceSqlite<DealActivityDbContext, MDealActivityEntity>().LogCustom(async (dbContext) => {
    var list = dbContext.Items.Where(x => x.DealId == 1).Select(p => new MDealActivityEntityBasic {Id = p.Id, DealId = p.DealId }).ToList();
    list.ForEach(data =>
    {
        if (data != null)
        {
            Console.WriteLine($"--------------------------");
            Console.WriteLine($"Id : {data.Id}");
            Console.WriteLine($"DealId : {data.DealId}");
        }
    });
    Console.WriteLine($"=========================");

    var fullName =  await dbContext.Items.Where(x => x.Id == 1).Select(p => p.DealId).FirstOrDefaultAsync();
    Console.WriteLine($"DealId : {fullName}");
});