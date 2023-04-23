using VegunSoft.Framework.Paging.Provider.Request;
using VegunSoft.Framework.Paging.Provider.Response;
using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.PRF.ProductFeature.Data.Db.Contexts;
using VSoft.Company.PRF.ProductFeature.Data.Entity.Models;

namespace VSoft.Company.PRF.ProductFeature.Repository.Services;

public interface IProductFeatureRepository : IEfcRepositoryEntityMgmtId<ProductFeatureDbContext, MProductFeatureEntity, int>
{

    string? GetFullName(int? id);

    Task<string?> GetFullNameAsync(int? id);

    Task<PagedList<MProductFeatureEntity>> GetTableByKeySearchAsync(string keySearch, PagingParameters pagParams);
}
