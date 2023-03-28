using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.POR.ProductOrder.Data.Db.Contexts;
using VSoft.Company.POR.ProductOrder.Data.Entity.Models;
using VSoft.Company.POR.ProductOrder.Repository.Services;

namespace VSoft.Company.POR.ProductOrder.Repository.Efc.Services;

public interface IProductOrderRepositoryEfc : IProductOrderRepository, IEfcRepositoryEntityMgmtId<ProductOrderDbContext, MProductOrderEntity, int>
{
   
}
