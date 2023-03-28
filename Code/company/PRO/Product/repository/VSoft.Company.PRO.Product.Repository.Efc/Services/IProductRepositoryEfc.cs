using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.PRO.Product.Data.Db.Contexts;
using VSoft.Company.PRO.Product.Data.Entity.Models;
using VSoft.Company.PRO.Product.Repository.Services;

namespace VSoft.Company.PRO.Product.Repository.Efc.Services;

public interface IProductRepositoryEfc : IProductRepository, IEfcRepositoryEntityMgmtId<ProductDbContext, MProductEntity, int>
{
   
}
