using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.POR.ProductOrder.Business.Dto.Request;
using VSoft.Company.POR.ProductOrder.Business.Dto.Response;

namespace VSoft.Company.POR.ProductOrder.Business.Services;

public interface IProductOrderMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByInt request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByInt request);

    ProductOrderFindDtoResponse Find(MDtoRequestFindByInt request);

    Task<ProductOrderFindDtoResponse> FindAsync(MDtoRequestFindByInt request);

    ProductOrderFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request);

    Task<ProductOrderFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request);

    ProductOrderInsertDtoResponse Create(ProductOrderInsertDtoRequest request);

    Task<ProductOrderInsertDtoResponse> CreateAsync(ProductOrderInsertDtoRequest request);

    ProductOrderInsertRangeDtoResponse CreateRange(ProductOrderInsertRangeDtoRequest request);

    Task<ProductOrderInsertRangeDtoResponse> CreateRangeAsync(ProductOrderInsertRangeDtoRequest request);

    ProductOrderUpdateDtoResponse Update(ProductOrderUpdateDtoRequest request);

    Task<ProductOrderUpdateDtoResponse> UpdateAsync(ProductOrderUpdateDtoRequest request);

    ProductOrderUpdateRangeDtoResponse UpdateRange(ProductOrderUpdateRangeDtoRequest request);

    Task<ProductOrderUpdateRangeDtoResponse> UpdateRangeAsync(ProductOrderUpdateRangeDtoRequest request);

    ProductOrderDeleteDtoResponse Delete(ProductOrderDeleteDtoRequest request);

    Task<ProductOrderDeleteDtoResponse> DeleteAsync(ProductOrderDeleteDtoRequest request);

    ProductOrderDeleteRangeDtoResponse DeleteRange(ProductOrderDeleteRangeDtoRequest request);

    Task<ProductOrderDeleteRangeDtoResponse> DeleteRangeAsync(ProductOrderDeleteRangeDtoRequest request);

    Task<ProductOrderSaveRangeDtoResponse> SaveRangeAsync(ProductOrderSaveRangeDtoRequest request);

    Task<ProductOrderSaveRangeDtoResponse> SaveRangeTransactionAsync(ProductOrderSaveRangeDtoRequest request);
}
