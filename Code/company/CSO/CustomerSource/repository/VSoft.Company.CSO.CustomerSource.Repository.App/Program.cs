// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.SqlServer.Methods;
using VSoft.Company.CSO.CustomerSource.Data.Db.Contexts;
using VSoft.Company.CSO.CustomerSource.Data.Entity.Models;
using VSoft.Company.CSO.CustomerSource.Repository.Efc.Provider.Services;
using VSoft.Company.CSO.CustomerSource.Repository.Services;


var serviceCollection = new ServiceCollection();

serviceCollection?.AddDbContext<CustomerSourceDbContext>((builder) =>
{
    builder.UseSqlServer(new MDbConnectionCfg());
});
serviceCollection?.AddScoped<ICustomerSourceRepository, EfcCustomerSourceRepository>();
var serviceProvider = serviceCollection?.BuildServiceProvider();

var repository = serviceProvider?.GetService<ICustomerSourceRepository>();

var id = 63452;
var entity = await (repository?.GetByIdAsync(id) ?? Task.FromResult<MCustomerSourceEntity?>(null));
Console.WriteLine($"CustomerSourceId: {entity?.Id}");
Console.WriteLine($"CustomerSourceFullName: {entity?.Name}");