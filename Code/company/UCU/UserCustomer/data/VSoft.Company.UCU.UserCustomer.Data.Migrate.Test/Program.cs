using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Efc.Migrate.Provider.Sqlite.Services;
using VSoft.Company.UCU.UserCustomer.Data.Db.Contexts;
using VSoft.Company.UCU.UserCustomer.Data.Entity.Models;
await new EfcSingleMigrateServiceSqlite<UserCustomerDbContext, MUserCustomerEntity>().LogCustom(async (dbContext) => {
    var list = dbContext.Items.Where(x => x.CustomerId == 1).Select(p => new MUserCustomerEntityBasic {Id = p.Id, CustomerId = p.CustomerId }).ToList();
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
    Console.WriteLine($"CustomerId : {fullName}");
});