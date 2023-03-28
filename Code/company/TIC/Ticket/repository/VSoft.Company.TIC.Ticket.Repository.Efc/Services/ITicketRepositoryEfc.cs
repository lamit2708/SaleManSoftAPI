using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.TIC.Ticket.Data.Db.Contexts;
using VSoft.Company.TIC.Ticket.Data.Entity.Models;
using VSoft.Company.TIC.Ticket.Repository.Services;

namespace VSoft.Company.TIC.Ticket.Repository.Efc.Services;

public interface ITicketRepositoryEfc : ITicketRepository, IEfcRepositoryEntityMgmtId<TicketDbContext, MTicketEntity, int>
{
   
}
