using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.PRC.ProductCategory.Business.Dto.Request;
using VSoft.Company.PRC.ProductCategory.Business.Dto.Response;

namespace VSoft.Company.PRC.ProductCategory.Client.Services;

public interface IProductCategoryClient : IApiDtoClientJSon<IProductCategoryClient>
{
    Task<ProductCategoryTableKeySearchDtoResponse> GetTableByKeyword(ProductCategoryTableKeySearchDtoRequest request);

    Task<ProductCategoryFindDtoResponse> FindAsync(MDtoRequestFindByString request);

    Task<ProductCategoryFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<ProductCategoryInsertDtoResponse> CreateAsync(ProductCategoryInsertDtoRequest request);

    Task<ProductCategoryInsertRangeDtoResponse> CreateRangeAsync(ProductCategoryInsertRangeDtoRequest request);

    Task<ProductCategoryUpdateDtoResponse> UpdateAsync(ProductCategoryUpdateDtoRequest request);

    Task<ProductCategoryUpdateRangeDtoResponse> UpdateRangeAsync(ProductCategoryUpdateRangeDtoRequest request);

    Task<ProductCategoryDeleteDtoResponse> DeleteAsync(ProductCategoryDeleteDtoRequest request);

    Task<ProductCategoryDeleteRangeDtoResponse> DeleteRangeAsync(ProductCategoryDeleteRangeDtoRequest request);

    Task<ProductCategorySaveRangeDtoResponse> SaveRangeAsync(ProductCategorySaveRangeDtoRequest request);

}