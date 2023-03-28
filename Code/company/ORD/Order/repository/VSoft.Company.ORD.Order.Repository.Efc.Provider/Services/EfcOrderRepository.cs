using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Repository.Id.Efc.Provider.Services;
using VSoft.Company.ORD.Order.Data.Db.Contexts;
using VSoft.Company.ORD.Order.Data.Entity.Models;
using VSoft.Company.ORD.Order.Repository.Efc.Services;

namespace VSoft.Company.ORD.Order.Repository.Efc.Provider.Services;

public class EfcOrderRepository : EFcRepositoryEntityMgmtId<OrderDbContext, MOrderEntity, int>, IOrderRepositoryEfc
{

    public EfcOrderRepository(OrderDbContext dbContext) : base(dbContext, dbContext.Items)
    {

    }

    public string? GetFullName(int? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.Id.ToString() ?? string.Empty).FirstOrDefault();
    }

    public Task<string?> GetFullNameAsync(int? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.Id.ToString() ?? string.Empty).FirstOrDefaultAsync() ;
    }
}
