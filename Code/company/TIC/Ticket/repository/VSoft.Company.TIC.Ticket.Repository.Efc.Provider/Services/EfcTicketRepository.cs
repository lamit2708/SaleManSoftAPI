using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Repository.Id.Efc.Provider.Services;
using VSoft.Company.TIC.Ticket.Data.Db.Contexts;
using VSoft.Company.TIC.Ticket.Data.Entity.Models;
using VSoft.Company.TIC.Ticket.Repository.Efc.Services;

namespace VSoft.Company.TIC.Ticket.Repository.Efc.Provider.Services;

public class EfcTicketRepository : EFcRepositoryEntityMgmtId<TicketDbContext, MTicketEntity, int>, ITicketRepositoryEfc
{

    public EfcTicketRepository(TicketDbContext dbContext) : base(dbContext, dbContext.Items)
    {

    }

    public string? GetFullName(int? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.Name ?? string.Empty).FirstOrDefault();
    }

    public Task<string?> GetFullNameAsync(int? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.Name ?? string.Empty).FirstOrDefaultAsync() ;
    }
}
