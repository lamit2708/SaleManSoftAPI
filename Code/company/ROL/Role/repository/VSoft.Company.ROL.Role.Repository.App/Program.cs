// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.SqlServer.Methods;
using VSoft.Company.ROL.Role.Data.Db.Contexts;
using VSoft.Company.ROL.Role.Data.Entity.Models;
using VSoft.Company.ROL.Role.Repository.Efc.Provider.Services;
using VSoft.Company.ROL.Role.Repository.Services;


var serviceCollection = new ServiceCollection();

serviceCollection?.AddDbContext<RoleDbContext>((builder) =>
{
    builder.UseSqlServer(new MDbConnectionCfg());
});
serviceCollection?.AddScoped<IRoleRepository, EfcRoleRepository>();
var serviceProvider = serviceCollection?.BuildServiceProvider();

var repository = serviceProvider?.GetService<IRoleRepository>();

var id = 63452;
var entity = await (repository?.GetByIdAsync(id) ?? Task.FromResult<MRoleEntity?>(null));
Console.WriteLine($"RoleId: {entity?.Id}");
Console.WriteLine($"RoleFullName: {entity?.Name}");