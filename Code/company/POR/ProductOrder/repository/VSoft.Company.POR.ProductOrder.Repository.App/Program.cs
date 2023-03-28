// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.SqlServer.Methods;
using VSoft.Company.POR.ProductOrder.Data.Db.Contexts;
using VSoft.Company.POR.ProductOrder.Data.Entity.Models;
using VSoft.Company.POR.ProductOrder.Repository.Efc.Provider.Services;
using VSoft.Company.POR.ProductOrder.Repository.Services;


var serviceCollection = new ServiceCollection();

serviceCollection?.AddDbContext<ProductOrderDbContext>((builder) =>
{
    builder.UseSqlServer(new MDbConnectionCfg());
});
serviceCollection?.AddScoped<IProductOrderRepository, EfcProductOrderRepository>();
var serviceProvider = serviceCollection?.BuildServiceProvider();

var repository = serviceProvider?.GetService<IProductOrderRepository>();

var id = 63452;
var entity = await (repository?.GetByIdAsync(id) ?? Task.FromResult<MProductOrderEntity?>(null));
Console.WriteLine($"ProductOrderId: {entity?.Id}");
Console.WriteLine($"ProductOrderOrderId: {entity?.OrderId}");