using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.POR.ProductOrder.Business.Dto.Request;
using VSoft.Company.POR.ProductOrder.Business.Dto.Response;

namespace VSoft.Company.POR.ProductOrder.Client.Services;

public interface IProductOrderClient: IApiDtoClientJSon<IProductOrderClient>
{  

    Task<ProductOrderFindDtoResponse> FindAsync(MDtoRequestFindByString request);

    Task<ProductOrderFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<ProductOrderInsertDtoResponse> CreateAsync(ProductOrderInsertDtoRequest request);

    Task<ProductOrderInsertRangeDtoResponse> CreateRangeAsync(ProductOrderInsertRangeDtoRequest request);

    Task<ProductOrderUpdateDtoResponse> UpdateAsync(ProductOrderUpdateDtoRequest request);

    Task<ProductOrderUpdateRangeDtoResponse> UpdateRangeAsync(ProductOrderUpdateRangeDtoRequest request);

    Task<ProductOrderDeleteDtoResponse> DeleteAsync(ProductOrderDeleteDtoRequest request);

    Task<ProductOrderDeleteRangeDtoResponse> DeleteRangeAsync(ProductOrderDeleteRangeDtoRequest request);

    Task<ProductOrderSaveRangeDtoResponse> SaveRangeAsync(ProductOrderSaveRangeDtoRequest request);
   
}