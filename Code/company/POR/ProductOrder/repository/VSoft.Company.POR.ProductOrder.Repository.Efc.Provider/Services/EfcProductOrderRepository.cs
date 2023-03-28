using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Repository.Id.Efc.Provider.Services;
using VSoft.Company.POR.ProductOrder.Data.Db.Contexts;
using VSoft.Company.POR.ProductOrder.Data.Entity.Models;
using VSoft.Company.POR.ProductOrder.Repository.Efc.Services;

namespace VSoft.Company.POR.ProductOrder.Repository.Efc.Provider.Services;

public class EfcProductOrderRepository : EFcRepositoryEntityMgmtId<ProductOrderDbContext, MProductOrderEntity, int>, IProductOrderRepositoryEfc
{

    public EfcProductOrderRepository(ProductOrderDbContext dbContext) : base(dbContext, dbContext.Items)
    {

    }

    public string? GetFullName(long? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.OrderId.ToString() ?? string.Empty).FirstOrDefault();
    }

    public Task<string?> GetFullNameAsync(long? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.OrderId.ToString() ?? string.Empty).FirstOrDefaultAsync() ;
    }
}
