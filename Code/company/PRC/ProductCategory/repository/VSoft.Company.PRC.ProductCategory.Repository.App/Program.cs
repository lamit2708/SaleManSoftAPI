// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.SqlServer.Methods;
using VSoft.Company.PRC.ProductCategory.Data.Db.Contexts;
using VSoft.Company.PRC.ProductCategory.Data.Entity.Models;
using VSoft.Company.PRC.ProductCategory.Repository.Efc.Provider.Services;
using VSoft.Company.PRC.ProductCategory.Repository.Services;


var serviceCollection = new ServiceCollection();

serviceCollection?.AddDbContext<ProductCategoryDbContext>((builder) =>
{
    builder.UseSqlServer(new MDbConnectionCfg());
});
serviceCollection?.AddScoped<IProductCategoryRepository, EfcProductCategoryRepository>();
var serviceProvider = serviceCollection?.BuildServiceProvider();

var repository = serviceProvider?.GetService<IProductCategoryRepository>();

var id = 63452;
var entity = await (repository?.GetByIdAsync(id) ?? Task.FromResult<MProductCategoryEntity?>(null));
Console.WriteLine($"ProductCategoryId: {entity?.Id}");
Console.WriteLine($"ProductCategoryFullName: {entity?.Name}");