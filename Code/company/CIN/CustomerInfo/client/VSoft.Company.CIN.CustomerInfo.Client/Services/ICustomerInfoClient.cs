using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.CIN.CustomerInfo.Business.Dto.Request;
using VSoft.Company.CIN.CustomerInfo.Business.Dto.Response;

namespace VSoft.Company.CIN.CustomerInfo.Client.Services;

public interface ICustomerInfoClient: IApiDtoClientJSon<ICustomerInfoClient>
{  

    Task<CustomerInfoFindDtoResponse> FindAsync(MDtoRequestFindByString request);

    Task<CustomerInfoFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<CustomerInfoInsertDtoResponse> CreateAsync(CustomerInfoInsertDtoRequest request);

    Task<CustomerInfoInsertRangeDtoResponse> CreateRangeAsync(CustomerInfoInsertRangeDtoRequest request);

    Task<CustomerInfoUpdateDtoResponse> UpdateAsync(CustomerInfoUpdateDtoRequest request);

    Task<CustomerInfoUpdateRangeDtoResponse> UpdateRangeAsync(CustomerInfoUpdateRangeDtoRequest request);

    Task<CustomerInfoDeleteDtoResponse> DeleteAsync(CustomerInfoDeleteDtoRequest request);

    Task<CustomerInfoDeleteRangeDtoResponse> DeleteRangeAsync(CustomerInfoDeleteRangeDtoRequest request);

    Task<CustomerInfoSaveRangeDtoResponse> SaveRangeAsync(CustomerInfoSaveRangeDtoRequest request);
   
}