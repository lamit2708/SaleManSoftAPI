// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.SqlServer.Methods;
using VSoft.Company.CIN.CustomerInfo.Data.Db.Contexts;
using VSoft.Company.CIN.CustomerInfo.Data.Entity.Models;
using VSoft.Company.CIN.CustomerInfo.Repository.Efc.Provider.Services;
using VSoft.Company.CIN.CustomerInfo.Repository.Services;


var serviceCollection = new ServiceCollection();

serviceCollection?.AddDbContext<CustomerInfoDbContext>((builder) =>
{
    builder.UseSqlServer(new MDbConnectionCfg());
});
serviceCollection?.AddScoped<ICustomerInfoRepository, EfcCustomerInfoRepository>();
var serviceProvider = serviceCollection?.BuildServiceProvider();

var repository = serviceProvider?.GetService<ICustomerInfoRepository>();

var id = 63452;
var entity = await (repository?.GetByIdAsync(id) ?? Task.FromResult<MCustomerInfoEntity?>(null));
Console.WriteLine($"CustomerInfoId: {entity?.Id}");
Console.WriteLine($"CustomerInfoCustomerSourceId: {entity?.CustomerSourceId}");