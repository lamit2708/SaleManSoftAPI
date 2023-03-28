// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.SqlServer.Methods;
using VSoft.Company.ACT.Activity.Data.Db.Contexts;
using VSoft.Company.ACT.Activity.Data.Entity.Models;
using VSoft.Company.ACT.Activity.Repository.Efc.Provider.Services;
using VSoft.Company.ACT.Activity.Repository.Services;


var serviceCollection = new ServiceCollection();

serviceCollection?.AddDbContext<ActivityDbContext>((builder) =>
{
    builder.UseSqlServer(new MDbConnectionCfg());
});
serviceCollection?.AddScoped<IActivityRepository, EfcActivityRepository>();
var serviceProvider = serviceCollection?.BuildServiceProvider();

var repository = serviceProvider?.GetService<IActivityRepository>();

var id = 63452;
var entity = await (repository?.GetByIdAsync(id) ?? Task.FromResult<MActivityEntity?>(null));
Console.WriteLine($"ActivityId: {entity?.Id}");
Console.WriteLine($"ActivityFullName: {entity?.Name}");