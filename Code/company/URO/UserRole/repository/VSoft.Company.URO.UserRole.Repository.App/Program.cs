// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.SqlServer.Methods;
using VSoft.Company.URO.UserRole.Data.Db.Contexts;
using VSoft.Company.URO.UserRole.Data.Entity.Models;
using VSoft.Company.URO.UserRole.Repository.Efc.Provider.Services;
using VSoft.Company.URO.UserRole.Repository.Services;


var serviceCollection = new ServiceCollection();

serviceCollection?.AddDbContext<UserRoleDbContext>((builder) =>
{
    builder.UseSqlServer(new MDbConnectionCfg());
});
serviceCollection?.AddScoped<IUserRoleRepository, EfcUserRoleRepository>();
var serviceProvider = serviceCollection?.BuildServiceProvider();

var repository = serviceProvider?.GetService<IUserRoleRepository>();

var id = 63452;
var entity = await (repository?.GetByIdAsync(id) ?? Task.FromResult<MUserRoleEntity?>(null));
Console.WriteLine($"UserRoleId: {entity?.Id}");
Console.WriteLine($"UserRoleUserId: {entity?.UserId}");