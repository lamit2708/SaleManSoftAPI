using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.TIC.Ticket.Data.Db.Contexts;
using VSoft.Company.TIC.Ticket.Data.Entity.Models;
await new EfcSingleMigrateServiceMySQL<TicketDbContext, MTicketEntity>().LogCount();