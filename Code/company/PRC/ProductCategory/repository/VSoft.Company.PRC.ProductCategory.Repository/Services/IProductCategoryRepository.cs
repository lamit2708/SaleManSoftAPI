using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.PRC.ProductCategory.Data.Db.Contexts;
using VSoft.Company.PRC.ProductCategory.Data.Entity.Models;

namespace VSoft.Company.PRC.ProductCategory.Repository.Services;

public interface IProductCategoryRepository : IEfcRepositoryEntityMgmtId<ProductCategoryDbContext, MProductCategoryEntity, int>
{

    string? GetFullName(int? id);

    Task<string?> GetFullNameAsync(int? id);

    Task<List<MProductCategoryEntity>> GetProductCategorysByNameAsync(string name);

    //MProductCategoryEntity? CreateWithKeyword(MProductCategoryEntity entity);

    //MProductCategoryEntity? UpdateWithKeyword(MProductCategoryEntity entity);

}
