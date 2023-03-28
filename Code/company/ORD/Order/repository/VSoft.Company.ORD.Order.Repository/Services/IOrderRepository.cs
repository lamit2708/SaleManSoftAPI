using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.ORD.Order.Data.Db.Contexts;
using VSoft.Company.ORD.Order.Data.Entity.Models;

namespace VSoft.Company.ORD.Order.Repository.Services;

public interface IOrderRepository : IEfcRepositoryEntityMgmtId<OrderDbContext, MOrderEntity, int>
{

    string? GetFullName(int? id);

    Task<string?> GetFullNameAsync(int? id);
}
