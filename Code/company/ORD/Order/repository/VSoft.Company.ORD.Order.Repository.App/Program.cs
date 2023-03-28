// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.SqlServer.Methods;
using VSoft.Company.ORD.Order.Data.Db.Contexts;
using VSoft.Company.ORD.Order.Data.Entity.Models;
using VSoft.Company.ORD.Order.Repository.Efc.Provider.Services;
using VSoft.Company.ORD.Order.Repository.Services;


var serviceCollection = new ServiceCollection();

serviceCollection?.AddDbContext<OrderDbContext>((builder) =>
{
    builder.UseSqlServer(new MDbConnectionCfg());
});
serviceCollection?.AddScoped<IOrderRepository, EfcOrderRepository>();
var serviceProvider = serviceCollection?.BuildServiceProvider();

var repository = serviceProvider?.GetService<IOrderRepository>();

var id = 63452;
var entity = await (repository?.GetByIdAsync(id) ?? Task.FromResult<MOrderEntity?>(null));
Console.WriteLine($"OrderId: {entity?.Id}");
Console.WriteLine($"CustomerId: {entity?.CustomerId}");