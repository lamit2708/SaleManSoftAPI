// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.SqlServer.Methods;
using VSoft.Company.QUE.Question.Data.Db.Contexts;
using VSoft.Company.QUE.Question.Data.Entity.Models;
using VSoft.Company.QUE.Question.Repository.Efc.Provider.Services;
using VSoft.Company.QUE.Question.Repository.Services;


var serviceCollection = new ServiceCollection();

serviceCollection?.AddDbContext<QuestionDbContext>((builder) =>
{
    builder.UseSqlServer(new MDbConnectionCfg());
});
serviceCollection?.AddScoped<IQuestionRepository, EfcQuestionRepository>();
var serviceProvider = serviceCollection?.BuildServiceProvider();

var repository = serviceProvider?.GetService<IQuestionRepository>();

var id = 63452;
var entity = await (repository?.GetByIdAsync(id) ?? Task.FromResult<MQuestionEntity?>(null));
Console.WriteLine($"QuestionId: {entity?.Id}");
Console.WriteLine($"QuestionTicketId: {entity?.TicketId}");