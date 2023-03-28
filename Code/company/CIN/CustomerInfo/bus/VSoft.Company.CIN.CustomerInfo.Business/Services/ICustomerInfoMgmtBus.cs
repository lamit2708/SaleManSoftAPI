using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.CIN.CustomerInfo.Business.Dto.Request;
using VSoft.Company.CIN.CustomerInfo.Business.Dto.Response;

namespace VSoft.Company.CIN.CustomerInfo.Business.Services;

public interface ICustomerInfoMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByLong request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByLong request);

    CustomerInfoFindDtoResponse Find(MDtoRequestFindByLong request);

    Task<CustomerInfoFindDtoResponse> FindAsync(MDtoRequestFindByLong request);

    CustomerInfoFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request);

    Task<CustomerInfoFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request);

    CustomerInfoInsertDtoResponse Create(CustomerInfoInsertDtoRequest request);

    Task<CustomerInfoInsertDtoResponse> CreateAsync(CustomerInfoInsertDtoRequest request);

    CustomerInfoInsertRangeDtoResponse CreateRange(CustomerInfoInsertRangeDtoRequest request);

    Task<CustomerInfoInsertRangeDtoResponse> CreateRangeAsync(CustomerInfoInsertRangeDtoRequest request);

    CustomerInfoUpdateDtoResponse Update(CustomerInfoUpdateDtoRequest request);

    Task<CustomerInfoUpdateDtoResponse> UpdateAsync(CustomerInfoUpdateDtoRequest request);

    CustomerInfoUpdateRangeDtoResponse UpdateRange(CustomerInfoUpdateRangeDtoRequest request);

    Task<CustomerInfoUpdateRangeDtoResponse> UpdateRangeAsync(CustomerInfoUpdateRangeDtoRequest request);

    CustomerInfoDeleteDtoResponse Delete(CustomerInfoDeleteDtoRequest request);

    Task<CustomerInfoDeleteDtoResponse> DeleteAsync(CustomerInfoDeleteDtoRequest request);

    CustomerInfoDeleteRangeDtoResponse DeleteRange(CustomerInfoDeleteRangeDtoRequest request);

    Task<CustomerInfoDeleteRangeDtoResponse> DeleteRangeAsync(CustomerInfoDeleteRangeDtoRequest request);

    Task<CustomerInfoSaveRangeDtoResponse> SaveRangeAsync(CustomerInfoSaveRangeDtoRequest request);

    Task<CustomerInfoSaveRangeDtoResponse> SaveRangeTransactionAsync(CustomerInfoSaveRangeDtoRequest request);
}
