// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.SqlServer.Methods;
using VSoft.Company.VDT.VDealTag.Data.Db.Contexts;
using VSoft.Company.VDT.VDealTag.Data.Entity.Models;
using VSoft.Company.VDT.VDealTag.Repository.Efc.Provider.Services;
using VSoft.Company.VDT.VDealTag.Repository.Services;


var serviceCollection = new ServiceCollection();

serviceCollection?.AddDbContext<VDealTagDbContext>((builder) =>
{
    builder.UseSqlServer(new MDbConnectionCfg());
});
serviceCollection?.AddScoped<IVDealTagRepository, EfcVDealTagRepository>();
var serviceProvider = serviceCollection?.BuildServiceProvider();

var repository = serviceProvider?.GetService<IVDealTagRepository>();

var id = 63452;
var entity = await (repository?.GetByIdAsync(id) ?? Task.FromResult<MVDealTagEntity?>(null));
Console.WriteLine($"VDealTagId: {entity?.Id}");
Console.WriteLine($"VDealTagFullName: {entity?.CustomerName}");