using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.TIC.Ticket.Data.Db.Contexts;
using VSoft.Company.TIC.Ticket.Data.Entity.Models;

namespace VSoft.Company.TIC.Ticket.Repository.Services;

public interface ITicketRepository : IEfcRepositoryEntityMgmtId<TicketDbContext, MTicketEntity, int>
{

    string? GetFullName(int? id);

    Task<string?> GetFullNameAsync(int? id);
}
