using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.POR.ProductOrder.Data.Db.Contexts;
using VSoft.Company.POR.ProductOrder.Data.Entity.Models;

namespace VSoft.Company.POR.ProductOrder.Repository.Services;

public interface IProductOrderRepository : IEfcRepositoryEntityMgmtId<ProductOrderDbContext, MProductOrderEntity, int>
{

    string? GetFullName(long? id);

    Task<string?> GetFullNameAsync(long? id);
}
