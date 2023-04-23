using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VegunSoft.Framework.Paging.Provider.Request;
using VegunSoft.Framework.Paging.Provider.Response;
using VSoft.Company.PRF.ProductFeature.Business.Dto.Data;
using VSoft.Company.PRF.ProductFeature.Business.Dto.Request;
using VSoft.Company.PRF.ProductFeature.Business.Dto.Response;

namespace VSoft.Company.PRF.ProductFeature.Business.Services;

public interface IProductFeatureMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByInt request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByInt request);

    ProductFeatureFindDtoResponse Find(MDtoRequestFindByInt request);

    Task<ProductFeatureFindDtoResponse> FindAsync(MDtoRequestFindByInt request);

    ProductFeatureFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request);

    Task<ProductFeatureFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request);

    ProductFeatureInsertDtoResponse Create(ProductFeatureInsertDtoRequest request);

    Task<ProductFeatureInsertDtoResponse> CreateAsync(ProductFeatureInsertDtoRequest request);

    ProductFeatureInsertRangeDtoResponse CreateRange(ProductFeatureInsertRangeDtoRequest request);

    Task<ProductFeatureInsertRangeDtoResponse> CreateRangeAsync(ProductFeatureInsertRangeDtoRequest request);

    ProductFeatureUpdateDtoResponse Update(ProductFeatureUpdateDtoRequest request);

    Task<ProductFeatureUpdateDtoResponse> UpdateAsync(ProductFeatureUpdateDtoRequest request);

    ProductFeatureUpdateRangeDtoResponse UpdateRange(ProductFeatureUpdateRangeDtoRequest request);

    Task<ProductFeatureUpdateRangeDtoResponse> UpdateRangeAsync(ProductFeatureUpdateRangeDtoRequest request);

    ProductFeatureDeleteDtoResponse Delete(ProductFeatureDeleteDtoRequest request);

    Task<ProductFeatureDeleteDtoResponse> DeleteAsync(ProductFeatureDeleteDtoRequest request);

    ProductFeatureDeleteRangeDtoResponse DeleteRange(ProductFeatureDeleteRangeDtoRequest request);

    Task<ProductFeatureDeleteRangeDtoResponse> DeleteRangeAsync(ProductFeatureDeleteRangeDtoRequest request);

    Task<ProductFeatureSaveRangeDtoResponse> SaveRangeAsync(ProductFeatureSaveRangeDtoRequest request);

    Task<ProductFeatureSaveRangeDtoResponse> SaveRangeTransactionAsync(ProductFeatureSaveRangeDtoRequest request);

    Task<ProductFeatureTableKeySearchDtoResponse> GetTableByKeySearch(ProductFeatureTableKeySearchDtoRequest request);

    Task<ProductFeatureKeyValueResponse> GetAll();
}
