using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Efc.Migrate.Provider.Sqlite.Services;
using VSoft.Company.ANW.Anwser.Data.Db.Contexts;
using VSoft.Company.ANW.Anwser.Data.Entity.Models;
await new EfcSingleMigrateServiceSqlite<AnwserDbContext, MAnwserEntity>().LogCustom(async (dbContext) =>
{
    var list = dbContext.Items.Where(x => x.QuestionId == 1).Select(p => new MAnwserEntityBasic { Id = p.Id, QuestionId = p.QuestionId }).ToList();
    list.ForEach(data =>
    {
        if (data != null)
        {
            Console.WriteLine($"--------------------------");
            Console.WriteLine($"Id : {data.Id}");
            Console.WriteLine($"QuestionId : {data.QuestionId}");
        }
    });
    Console.WriteLine($"=========================");

    var fullName = await dbContext.Items.Where(x => x.Id == 1).Select(p => p.QuestionId).FirstOrDefaultAsync();
    Console.WriteLine($"QuestionId : {fullName}");
});