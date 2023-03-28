// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.SqlServer.Methods;
using VSoft.Company.TIC.Ticket.Data.Db.Contexts;
using VSoft.Company.TIC.Ticket.Data.Entity.Models;
using VSoft.Company.TIC.Ticket.Repository.Efc.Provider.Services;
using VSoft.Company.TIC.Ticket.Repository.Services;


var serviceCollection = new ServiceCollection();

serviceCollection?.AddDbContext<TicketDbContext>((builder) =>
{
    builder.UseSqlServer(new MDbConnectionCfg());
});
serviceCollection?.AddScoped<ITicketRepository, EfcTicketRepository>();
var serviceProvider = serviceCollection?.BuildServiceProvider();

var repository = serviceProvider?.GetService<ITicketRepository>();

var id = 63452;
var entity = await (repository?.GetByIdAsync(id) ?? Task.FromResult<MTicketEntity?>(null));
Console.WriteLine($"TicketId: {entity?.Id}");
Console.WriteLine($"TicketFullName: {entity?.Name}");