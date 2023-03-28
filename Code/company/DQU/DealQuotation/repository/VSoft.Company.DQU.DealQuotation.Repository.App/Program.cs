// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.SqlServer.Methods;
using VSoft.Company.DQU.DealQuotation.Data.Db.Contexts;
using VSoft.Company.DQU.DealQuotation.Data.Entity.Models;
using VSoft.Company.DQU.DealQuotation.Repository.Efc.Provider.Services;
using VSoft.Company.DQU.DealQuotation.Repository.Services;


var serviceCollection = new ServiceCollection();

serviceCollection?.AddDbContext<DealQuotationDbContext>((builder) =>
{
    builder.UseSqlServer(new MDbConnectionCfg());
});
serviceCollection?.AddScoped<IDealQuotationRepository, EfcDealQuotationRepository>();
var serviceProvider = serviceCollection?.BuildServiceProvider();

var repository = serviceProvider?.GetService<IDealQuotationRepository>();

var id = 63452;
var entity = await (repository?.GetByIdAsync(id) ?? Task.FromResult<MDealQuotationEntity?>(null));
Console.WriteLine($"DealQuotationId: {entity?.Id}");
Console.WriteLine($"DealQuotationDealId: {entity?.DealId}");