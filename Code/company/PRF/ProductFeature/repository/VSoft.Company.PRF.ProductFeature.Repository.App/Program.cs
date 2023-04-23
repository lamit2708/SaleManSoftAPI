// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.SqlServer.Methods;
using VSoft.Company.PRF.ProductFeature.Data.Db.Contexts;
using VSoft.Company.PRF.ProductFeature.Data.Entity.Models;
using VSoft.Company.PRF.ProductFeature.Repository.Efc.Provider.Services;
using VSoft.Company.PRF.ProductFeature.Repository.Services;


var serviceCollection = new ServiceCollection();

serviceCollection?.AddDbContext<ProductFeatureDbContext>((builder) =>
{
    builder.UseSqlServer(new MDbConnectionCfg());
});
serviceCollection?.AddScoped<IProductFeatureRepository, EfcProductFeatureRepository>();
var serviceProvider = serviceCollection?.BuildServiceProvider();

var repository = serviceProvider?.GetService<IProductFeatureRepository>();

var id = 63452;
var entity = await (repository?.GetByIdAsync(id) ?? Task.FromResult<MProductFeatureEntity?>(null));
Console.WriteLine($"ProductFeatureId: {entity?.Id}");
Console.WriteLine($"ProductFeatureFullName: {entity?.Name}");