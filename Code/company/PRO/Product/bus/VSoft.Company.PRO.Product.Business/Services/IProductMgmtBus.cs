using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.PRO.Product.Business.Dto.Request;
using VSoft.Company.PRO.Product.Business.Dto.Response;

namespace VSoft.Company.PRO.Product.Business.Services;

public interface IProductMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByInt request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByInt request);

    ProductFindDtoResponse Find(MDtoRequestFindByInt request);

    Task<ProductFindDtoResponse> FindAsync(MDtoRequestFindByInt request);

    ProductFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request);

    Task<ProductFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request);

    ProductInsertDtoResponse Create(ProductInsertDtoRequest request);

    Task<ProductInsertDtoResponse> CreateAsync(ProductInsertDtoRequest request);

    ProductInsertRangeDtoResponse CreateRange(ProductInsertRangeDtoRequest request);

    Task<ProductInsertRangeDtoResponse> CreateRangeAsync(ProductInsertRangeDtoRequest request);

    ProductUpdateDtoResponse Update(ProductUpdateDtoRequest request);

    Task<ProductUpdateDtoResponse> UpdateAsync(ProductUpdateDtoRequest request);

    ProductUpdateRangeDtoResponse UpdateRange(ProductUpdateRangeDtoRequest request);

    Task<ProductUpdateRangeDtoResponse> UpdateRangeAsync(ProductUpdateRangeDtoRequest request);

    ProductDeleteDtoResponse Delete(ProductDeleteDtoRequest request);

    Task<ProductDeleteDtoResponse> DeleteAsync(ProductDeleteDtoRequest request);

    ProductDeleteRangeDtoResponse DeleteRange(ProductDeleteRangeDtoRequest request);

    Task<ProductDeleteRangeDtoResponse> DeleteRangeAsync(ProductDeleteRangeDtoRequest request);

    Task<ProductSaveRangeDtoResponse> SaveRangeAsync(ProductSaveRangeDtoRequest request);

    Task<ProductSaveRangeDtoResponse> SaveRangeTransactionAsync(ProductSaveRangeDtoRequest request);
}
