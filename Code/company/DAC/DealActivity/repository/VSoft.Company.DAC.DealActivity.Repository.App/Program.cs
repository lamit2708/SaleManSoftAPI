// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.SqlServer.Methods;
using VSoft.Company.DAC.DealActivity.Data.Db.Contexts;
using VSoft.Company.DAC.DealActivity.Data.Entity.Models;
using VSoft.Company.DAC.DealActivity.Repository.Efc.Provider.Services;
using VSoft.Company.DAC.DealActivity.Repository.Services;


var serviceCollection = new ServiceCollection();

serviceCollection?.AddDbContext<DealActivityDbContext>((builder) =>
{
    builder.UseSqlServer(new MDbConnectionCfg());
});
serviceCollection?.AddScoped<IDealActivityRepository, EfcDealActivityRepository>();
var serviceProvider = serviceCollection?.BuildServiceProvider();

var repository = serviceProvider?.GetService<IDealActivityRepository>();

var id = 63452;
var entity = await (repository?.GetByIdAsync(id) ?? Task.FromResult<MDealActivityEntity?>(null));
Console.WriteLine($"DealActivityId: {entity?.Id}");
Console.WriteLine($"DealActivityDealId: {entity?.DealId}");