using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.PRF.ProductFeature.Business.Dto.Request;
using VSoft.Company.PRF.ProductFeature.Business.Dto.Response;

namespace VSoft.Company.PRF.ProductFeature.Client.Services;

public interface IProductFeatureClient : IApiDtoClientJSon<IProductFeatureClient>
{
    Task<ProductFeatureTableKeySearchDtoResponse> GetTableByKeyword(ProductFeatureTableKeySearchDtoRequest request);

    Task<ProductFeatureFindDtoResponse> FindAsync(MDtoRequestFindByInt request);

    Task<ProductFeatureFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<ProductFeatureInsertDtoResponse> CreateAsync(ProductFeatureInsertDtoRequest request);

    Task<ProductFeatureInsertRangeDtoResponse> CreateRangeAsync(ProductFeatureInsertRangeDtoRequest request);

    Task<ProductFeatureUpdateDtoResponse> UpdateAsync(ProductFeatureUpdateDtoRequest request);

    Task<ProductFeatureUpdateRangeDtoResponse> UpdateRangeAsync(ProductFeatureUpdateRangeDtoRequest request);

    Task<ProductFeatureDeleteDtoResponse> DeleteAsync(ProductFeatureDeleteDtoRequest request);

    Task<ProductFeatureDeleteRangeDtoResponse> DeleteRangeAsync(ProductFeatureDeleteRangeDtoRequest request);

    Task<ProductFeatureSaveRangeDtoResponse> SaveRangeAsync(ProductFeatureSaveRangeDtoRequest request);

    Task<ProductFeatureKeyValueResponse> GetAll();


}