using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Efc.Migrate.Provider.Sqlite.Services;
using VSoft.Company.DQU.DealQuotation.Data.Db.Contexts;
using VSoft.Company.DQU.DealQuotation.Data.Entity.Models;
await new EfcSingleMigrateServiceSqlite<DealQuotationDbContext, MDealQuotationEntity>().LogCustom(async (dbContext) => {
    var list = dbContext.Items.Where(x => x.DealId == 1).Select(p => new MDealQuotationEntityBasic {Id = p.Id, DealId = p.DealId }).ToList();
    list.ForEach(data =>
    {
        if (data != null)
        {
            Console.WriteLine($"--------------------------");
            Console.WriteLine($"Id : {data.Id}");
            Console.WriteLine($"Deal Id : {data.DealId}");
        }
    });
    Console.WriteLine($"=========================");

    var fullName =  await dbContext.Items.Where(x => x.Id == 1).Select(p => p.DealId).FirstOrDefaultAsync();
    Console.WriteLine($"FullName : {fullName}");
});