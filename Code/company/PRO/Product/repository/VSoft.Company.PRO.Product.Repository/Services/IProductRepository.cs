using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.PRO.Product.Data.Db.Contexts;
using VSoft.Company.PRO.Product.Data.Entity.Models;

namespace VSoft.Company.PRO.Product.Repository.Services;

public interface IProductRepository : IEfcRepositoryEntityMgmtId<ProductDbContext, MProductEntity, int>
{

    string? GetFullName(int? id);

    Task<string?> GetFullNameAsync(int? id);

    Task<List<MProductEntity>> GetByNameAsync(string name);


    MProductEntity? UpdateWithKeyword(MProductEntity entity);

    MProductEntity? CreateWithKeyword(MProductEntity entity);

}
