// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.SqlServer.Methods;
using VSoft.Company.DSH.DealStepHistory.Data.Db.Contexts;
using VSoft.Company.DSH.DealStepHistory.Data.Entity.Models;
using VSoft.Company.DSH.DealStepHistory.Repository.Efc.Provider.Services;
using VSoft.Company.DSH.DealStepHistory.Repository.Services;


var serviceCollection = new ServiceCollection();

serviceCollection?.AddDbContext<DealStepHistoryDbContext>((builder) =>
{
    builder.UseSqlServer(new MDbConnectionCfg());
});
serviceCollection?.AddScoped<IDealStepHistoryRepository, EfcDealStepHistoryRepository>();
var serviceProvider = serviceCollection?.BuildServiceProvider();

var repository = serviceProvider?.GetService<IDealStepHistoryRepository>();

var id = 63452;
var entity = await (repository?.GetByIdAsync(id) ?? Task.FromResult<MDealStepHistoryEntity?>(null));
Console.WriteLine($"DealStepHistoryId: {entity?.Id}");
Console.WriteLine($"DealStepHistoryDealStepId: {entity?.DealStepId}");