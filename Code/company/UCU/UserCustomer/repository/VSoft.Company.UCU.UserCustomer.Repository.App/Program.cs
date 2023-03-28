// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.SqlServer.Methods;
using VSoft.Company.UCU.UserCustomer.Data.Db.Contexts;
using VSoft.Company.UCU.UserCustomer.Data.Entity.Models;
using VSoft.Company.UCU.UserCustomer.Repository.Efc.Provider.Services;
using VSoft.Company.UCU.UserCustomer.Repository.Services;


var serviceCollection = new ServiceCollection();

serviceCollection?.AddDbContext<UserCustomerDbContext>((builder) =>
{
    builder.UseSqlServer(new MDbConnectionCfg());
});
serviceCollection?.AddScoped<IUserCustomerRepository, EfcUserCustomerRepository>();
var serviceProvider = serviceCollection?.BuildServiceProvider();

var repository = serviceProvider?.GetService<IUserCustomerRepository>();

var id = 63452;
var entity = await (repository?.GetByIdAsync(id) ?? Task.FromResult<MUserCustomerEntity?>(null));
Console.WriteLine($"UserCustomerId: {entity?.Id}");
Console.WriteLine($"UserCustomerCustomerId: {entity?.CustomerId}");