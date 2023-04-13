using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.PRC.ProductCategory.Business.Dto.Request;
using VSoft.Company.PRC.ProductCategory.Business.Dto.Response;

namespace VSoft.Company.PRC.ProductCategory.Business.Services;

public interface IProductCategoryMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByInt request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByInt request);

    ProductCategoryFindDtoResponse Find(MDtoRequestFindByInt request);

    Task<ProductCategoryFindDtoResponse> FindAsync(MDtoRequestFindByInt request);

    ProductCategoryFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request);

    Task<ProductCategoryFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request);

    ProductCategoryInsertDtoResponse Create(ProductCategoryInsertDtoRequest request);

    Task<ProductCategoryInsertDtoResponse> CreateAsync(ProductCategoryInsertDtoRequest request);

    ProductCategoryInsertRangeDtoResponse CreateRange(ProductCategoryInsertRangeDtoRequest request);

    Task<ProductCategoryInsertRangeDtoResponse> CreateRangeAsync(ProductCategoryInsertRangeDtoRequest request);

    ProductCategoryUpdateDtoResponse Update(ProductCategoryUpdateDtoRequest request);

    Task<ProductCategoryUpdateDtoResponse> UpdateAsync(ProductCategoryUpdateDtoRequest request);

    ProductCategoryUpdateRangeDtoResponse UpdateRange(ProductCategoryUpdateRangeDtoRequest request);

    Task<ProductCategoryUpdateRangeDtoResponse> UpdateRangeAsync(ProductCategoryUpdateRangeDtoRequest request);

    ProductCategoryDeleteDtoResponse Delete(ProductCategoryDeleteDtoRequest request);

    Task<ProductCategoryDeleteDtoResponse> DeleteAsync(ProductCategoryDeleteDtoRequest request);

    ProductCategoryDeleteRangeDtoResponse DeleteRange(ProductCategoryDeleteRangeDtoRequest request);

    Task<ProductCategoryDeleteRangeDtoResponse> DeleteRangeAsync(ProductCategoryDeleteRangeDtoRequest request);

    Task<ProductCategorySaveRangeDtoResponse> SaveRangeAsync(ProductCategorySaveRangeDtoRequest request);

    Task<ProductCategorySaveRangeDtoResponse> SaveRangeTransactionAsync(ProductCategorySaveRangeDtoRequest request);

    Task<ProductCategoryTableKeySearchDtoResponse> GetTableByKeySearch(ProductCategoryTableKeySearchDtoRequest request);

    Task<ProductCategoryFindRangeDtoResponse> GetAll();
}
