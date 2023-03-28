// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.SqlServer.Methods;
using VSoft.Company.TEA.Team.Data.Db.Contexts;
using VSoft.Company.TEA.Team.Data.Entity.Models;
using VSoft.Company.TEA.Team.Repository.Efc.Provider.Services;
using VSoft.Company.TEA.Team.Repository.Services;


var serviceCollection = new ServiceCollection();

serviceCollection?.AddDbContext<TeamDbContext>((builder) =>
{
    builder.UseSqlServer(new MDbConnectionCfg());
});
serviceCollection?.AddScoped<ITeamRepository, EfcTeamRepository>();
var serviceProvider = serviceCollection?.BuildServiceProvider();

var repository = serviceProvider?.GetService<ITeamRepository>();

var id = 63452;
var entity = await (repository?.GetByIdAsync(id) ?? Task.FromResult<MTeamEntity?>(null));
Console.WriteLine($"TeamId: {entity?.Id}");
Console.WriteLine($"TeamFullName: {entity?.Name}");