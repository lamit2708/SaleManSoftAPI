using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Efc.Migrate.Provider.Sqlite.Services;
using VSoft.Company.DSH.DealStepHistory.Data.Db.Contexts;
using VSoft.Company.DSH.DealStepHistory.Data.Entity.Models;
await new EfcSingleMigrateServiceSqlite<DealStepHistoryDbContext, MDealStepHistoryEntity>().LogCustom(async (dbContext) => {
    var list = dbContext.Items.Where(x => x.DealStepId == 1).Select(p => new MDealStepHistoryEntityBasic {Id = p.Id, DealStepId = p.DealStepId }).ToList();
    list.ForEach(data =>
    {
        if (data != null)
        {
            Console.WriteLine($"--------------------------");
            Console.WriteLine($"Id : {data.Id}");
            Console.WriteLine($"DealStepId : {data.DealStepId}");
        }
    });
    Console.WriteLine($"=========================");

    var fullName =  await dbContext.Items.Where(x => x.Id == 1).Select(p => p.DealStepId).FirstOrDefaultAsync();
    Console.WriteLine($"DealStepId : {fullName}");
});