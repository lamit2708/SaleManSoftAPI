using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.PRC.ProductCategory.Data.Db.Contexts;
using VSoft.Company.PRC.ProductCategory.Data.Entity.Models;
using VSoft.Company.PRC.ProductCategory.Repository.Services;

namespace VSoft.Company.PRC.ProductCategory.Repository.Efc.Services;

public interface IProductCategoryRepositoryEfc : IProductCategoryRepository, IEfcRepositoryEntityMgmtId<ProductCategoryDbContext, MProductCategoryEntity, int>
{

}
