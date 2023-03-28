using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.ORD.Order.Data.Db.Contexts;
using VSoft.Company.ORD.Order.Data.Entity.Models;
using VSoft.Company.ORD.Order.Repository.Services;

namespace VSoft.Company.ORD.Order.Repository.Efc.Services;

public interface IOrderRepositoryEfc : IOrderRepository, IEfcRepositoryEntityMgmtId<OrderDbContext, MOrderEntity, int>
{
   
}
