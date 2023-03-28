using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.ORD.Order.Business.Dto.Request;
using VSoft.Company.ORD.Order.Business.Dto.Response;

namespace VSoft.Company.ORD.Order.Business.Services;

public interface IOrderMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByInt request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByInt request);

    OrderFindDtoResponse Find(MDtoRequestFindByInt request);

    Task<OrderFindDtoResponse> FindAsync(MDtoRequestFindByInt request);

    OrderFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request);

    Task<OrderFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request);

    OrderInsertDtoResponse Create(OrderInsertDtoRequest request);

    Task<OrderInsertDtoResponse> CreateAsync(OrderInsertDtoRequest request);

    OrderInsertRangeDtoResponse CreateRange(OrderInsertRangeDtoRequest request);

    Task<OrderInsertRangeDtoResponse> CreateRangeAsync(OrderInsertRangeDtoRequest request);

    OrderUpdateDtoResponse Update(OrderUpdateDtoRequest request);

    Task<OrderUpdateDtoResponse> UpdateAsync(OrderUpdateDtoRequest request);

    OrderUpdateRangeDtoResponse UpdateRange(OrderUpdateRangeDtoRequest request);

    Task<OrderUpdateRangeDtoResponse> UpdateRangeAsync(OrderUpdateRangeDtoRequest request);

    OrderDeleteDtoResponse Delete(OrderDeleteDtoRequest request);

    Task<OrderDeleteDtoResponse> DeleteAsync(OrderDeleteDtoRequest request);

    OrderDeleteRangeDtoResponse DeleteRange(OrderDeleteRangeDtoRequest request);

    Task<OrderDeleteRangeDtoResponse> DeleteRangeAsync(OrderDeleteRangeDtoRequest request);

    Task<OrderSaveRangeDtoResponse> SaveRangeAsync(OrderSaveRangeDtoRequest request);

    Task<OrderSaveRangeDtoResponse> SaveRangeTransactionAsync(OrderSaveRangeDtoRequest request);
}
