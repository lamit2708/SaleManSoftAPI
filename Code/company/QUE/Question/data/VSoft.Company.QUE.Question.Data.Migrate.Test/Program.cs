using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Efc.Migrate.Provider.Sqlite.Services;
using VSoft.Company.QUE.Question.Data.Db.Contexts;
using VSoft.Company.QUE.Question.Data.Entity.Models;
await new EfcSingleMigrateServiceSqlite<QuestionDbContext, MQuestionEntity>().LogCustom(async (dbContext) => {
    var list = dbContext.Items.Where(x => x.TicketId == 1).Select(p => new MQuestionEntityBasic {Id = p.Id, TicketId = p.TicketId }).ToList();
    list.ForEach(data =>
    {
        if (data != null)
        {
            Console.WriteLine($"--------------------------");
            Console.WriteLine($"Id : {data.Id}");
            Console.WriteLine($"TicketId : {data.TicketId}");
        }
    });
    Console.WriteLine($"=========================");

    var fullName =  await dbContext.Items.Where(x => x.Id == 1).Select(p => p.TicketId).FirstOrDefaultAsync();
    Console.WriteLine($"TicketId : {fullName}");
});