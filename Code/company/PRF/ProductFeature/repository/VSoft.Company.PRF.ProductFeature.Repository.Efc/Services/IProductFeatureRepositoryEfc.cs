using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.PRF.ProductFeature.Data.Db.Contexts;
using VSoft.Company.PRF.ProductFeature.Data.Entity.Models;
using VSoft.Company.PRF.ProductFeature.Repository.Services;

namespace VSoft.Company.PRF.ProductFeature.Repository.Efc.Services;

public interface IProductFeatureRepositoryEfc : IProductFeatureRepository, IEfcRepositoryEntityMgmtId<ProductFeatureDbContext, MProductFeatureEntity, int>
{

}
