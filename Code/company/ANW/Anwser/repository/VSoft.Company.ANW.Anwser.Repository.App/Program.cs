// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.SqlServer.Methods;
using VSoft.Company.ANW.Anwser.Data.Db.Contexts;
using VSoft.Company.ANW.Anwser.Data.Entity.Models;
using VSoft.Company.ANW.Anwser.Repository.Efc.Provider.Services;
using VSoft.Company.ANW.Anwser.Repository.Services;


var serviceCollection = new ServiceCollection();

serviceCollection?.AddDbContext<AnwserDbContext>((builder) =>
{
    builder.UseSqlServer(new MDbConnectionCfg());
});
serviceCollection?.AddScoped<IAnwserRepository, EfcAnwserRepository>();
var serviceProvider = serviceCollection?.BuildServiceProvider();

var repository = serviceProvider?.GetService<IAnwserRepository>();

var id = 63452;
var entity = await (repository?.GetByIdAsync(id) ?? Task.FromResult<MAnwserEntity?>(null));
Console.WriteLine($"AnwserId: {entity?.Id}");
Console.WriteLine($"AnwserQuestionId: {entity?.QuestionId}");