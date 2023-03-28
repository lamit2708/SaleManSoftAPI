// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.SqlServer.Methods;
using VSoft.Company.DEA.Deal.Data.Db.Contexts;
using VSoft.Company.DEA.Deal.Data.Entity.Models;
using VSoft.Company.DEA.Deal.Repository.Efc.Provider.Services;
using VSoft.Company.DEA.Deal.Repository.Services;


var serviceCollection = new ServiceCollection();

serviceCollection?.AddDbContext<DealDbContext>((builder) =>
{
    builder.UseSqlServer(new MDbConnectionCfg());
});
serviceCollection?.AddScoped<IDealRepository, EfcDealRepository>();
var serviceProvider = serviceCollection?.BuildServiceProvider();

var repository = serviceProvider?.GetService<IDealRepository>();

var id = 63452;
var entity = await (repository?.GetByIdAsync(id) ?? Task.FromResult<MDealEntity?>(null));
Console.WriteLine($"DealId: {entity?.Id}");
Console.WriteLine($"DealFullName: {entity?.Name}");