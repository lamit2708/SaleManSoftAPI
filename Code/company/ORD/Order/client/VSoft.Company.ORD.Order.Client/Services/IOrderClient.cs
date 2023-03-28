using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.ORD.Order.Business.Dto.Request;
using VSoft.Company.ORD.Order.Business.Dto.Response;

namespace VSoft.Company.ORD.Order.Client.Services;

public interface IOrderClient: IApiDtoClientJSon<IOrderClient>
{  

    Task<OrderFindDtoResponse> FindAsync(MDtoRequestFindByString request);

    Task<OrderFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<OrderInsertDtoResponse> CreateAsync(OrderInsertDtoRequest request);

    Task<OrderInsertRangeDtoResponse> CreateRangeAsync(OrderInsertRangeDtoRequest request);

    Task<OrderUpdateDtoResponse> UpdateAsync(OrderUpdateDtoRequest request);

    Task<OrderUpdateRangeDtoResponse> UpdateRangeAsync(OrderUpdateRangeDtoRequest request);

    Task<OrderDeleteDtoResponse> DeleteAsync(OrderDeleteDtoRequest request);

    Task<OrderDeleteRangeDtoResponse> DeleteRangeAsync(OrderDeleteRangeDtoRequest request);

    Task<OrderSaveRangeDtoResponse> SaveRangeAsync(OrderSaveRangeDtoRequest request);
   
}