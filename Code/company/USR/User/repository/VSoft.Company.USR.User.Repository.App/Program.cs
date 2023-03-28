// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.SqlServer.Methods;
using VSoft.Company.USR.User.Data.Db.Contexts;
using VSoft.Company.USR.User.Data.Entity.Models;
using VSoft.Company.USR.User.Repository.Efc.Provider.Services;
using VSoft.Company.USR.User.Repository.Services;


var serviceCollection = new ServiceCollection();

serviceCollection?.AddDbContext<UserDbContext>((builder) =>
{
    builder.UseSqlServer(new MDbConnectionCfg());
});
serviceCollection?.AddScoped<IUserRepository, EfcUserRepository>();
var serviceProvider = serviceCollection?.BuildServiceProvider();

var repository = serviceProvider?.GetService<IUserRepository>();

var id = 63452;
var entity = await (repository?.GetByIdAsync(id) ?? Task.FromResult<MUserEntity?>(null));
Console.WriteLine($"UserId: {entity?.Id}");
Console.WriteLine($"UserFullName: {entity?.Name}");