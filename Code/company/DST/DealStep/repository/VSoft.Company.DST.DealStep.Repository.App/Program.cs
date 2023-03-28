// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.SqlServer.Methods;
using VSoft.Company.DST.DealStep.Data.Db.Contexts;
using VSoft.Company.DST.DealStep.Data.Entity.Models;
using VSoft.Company.DST.DealStep.Repository.Efc.Provider.Services;
using VSoft.Company.DST.DealStep.Repository.Services;


var serviceCollection = new ServiceCollection();

serviceCollection?.AddDbContext<DealStepDbContext>((builder) =>
{
    builder.UseSqlServer(new MDbConnectionCfg());
});
serviceCollection?.AddScoped<IDealStepRepository, EfcDealStepRepository>();
var serviceProvider = serviceCollection?.BuildServiceProvider();

var repository = serviceProvider?.GetService<IDealStepRepository>();

var id = 63452;
var entity = await (repository?.GetByIdAsync(id) ?? Task.FromResult<MDealStepEntity?>(null));
Console.WriteLine($"DealStepId: {entity?.Id}");
Console.WriteLine($"DealStepFullName: {entity?.Name}");