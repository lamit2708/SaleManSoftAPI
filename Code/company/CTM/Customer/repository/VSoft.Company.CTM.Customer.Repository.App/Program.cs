// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.SqlServer.Methods;
using VSoft.Company.CTM.Customer.Data.Db.Contexts;
using VSoft.Company.CTM.Customer.Data.Entity.Models;
using VSoft.Company.CTM.Customer.Repository.Efc.Provider.Services;
using VSoft.Company.CTM.Customer.Repository.Services;


var serviceCollection = new ServiceCollection();

serviceCollection?.AddDbContext<CustomerDbContext>((builder) =>
{
    builder.UseSqlServer(new MDbConnectionCfg());
});
serviceCollection?.AddScoped<ICustomerRepository, EfcCustomerRepository>();
var serviceProvider = serviceCollection?.BuildServiceProvider();

var repository = serviceProvider?.GetService<ICustomerRepository>();

var id = 63452;
var entity = await (repository?.GetByIdAsync(id) ?? Task.FromResult<MCustomerEntity?>(null));
Console.WriteLine($"CustomerId: {entity?.Id}");
Console.WriteLine($"CustomerFullName: {entity?.Name}");