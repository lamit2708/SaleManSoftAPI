using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.PRO.Product.Business.Dto.Request;
using VSoft.Company.PRO.Product.Business.Dto.Response;

namespace VSoft.Company.PRO.Product.Client.Services;

public interface IProductClient: IApiDtoClientJSon<IProductClient>
{  

    Task<ProductFindDtoResponse> FindAsync(MDtoRequestFindByInt request);

    Task<ProductFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<ProductInsertDtoResponse> CreateAsync(ProductInsertDtoRequest request);

    Task<ProductInsertRangeDtoResponse> CreateRangeAsync(ProductInsertRangeDtoRequest request);

    Task<ProductUpdateDtoResponse> UpdateAsync(ProductUpdateDtoRequest request);

    Task<ProductUpdateRangeDtoResponse> UpdateRangeAsync(ProductUpdateRangeDtoRequest request);

    Task<ProductDeleteDtoResponse> DeleteAsync(ProductDeleteDtoRequest request);

    Task<ProductDeleteRangeDtoResponse> DeleteRangeAsync(ProductDeleteRangeDtoRequest request);

    Task<ProductSaveRangeDtoResponse> SaveRangeAsync(ProductSaveRangeDtoRequest request);
    Task<ProductTableKeySearchDtoResponse> GetTableByKeyword(ProductTableKeySearchDtoRequest request);
    Task<ProductFindRangeDtoResponse> GetAll();
}