// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.SqlServer.Methods;
using VSoft.Company.PRI.Priority.Data.Db.Contexts;
using VSoft.Company.PRI.Priority.Data.Entity.Models;
using VSoft.Company.PRI.Priority.Repository.Efc.Provider.Services;
using VSoft.Company.PRI.Priority.Repository.Services;


var serviceCollection = new ServiceCollection();

serviceCollection?.AddDbContext<PriorityDbContext>((builder) =>
{
    builder.UseSqlServer(new MDbConnectionCfg());
});
serviceCollection?.AddScoped<IPriorityRepository, EfcPriorityRepository>();
var serviceProvider = serviceCollection?.BuildServiceProvider();

var repository = serviceProvider?.GetService<IPriorityRepository>();

var id = 63452;
var entity = await (repository?.GetByIdAsync(id) ?? Task.FromResult<MPriorityEntity?>(null));
Console.WriteLine($"PriorityId: {entity?.Id}");
Console.WriteLine($"PriorityFullName: {entity?.Name}");