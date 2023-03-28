using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.CSO.CustomerSource.Business.Dto.Request;
using VSoft.Company.CSO.CustomerSource.Business.Dto.Response;

namespace VSoft.Company.CSO.CustomerSource.Client.Services;

public interface ICustomerSourceClient: IApiDtoClientJSon<ICustomerSourceClient>
{  

    Task<CustomerSourceFindDtoResponse> FindAsync(MDtoRequestFindByString request);

    Task<CustomerSourceFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<CustomerSourceInsertDtoResponse> CreateAsync(CustomerSourceInsertDtoRequest request);

    Task<CustomerSourceInsertRangeDtoResponse> CreateRangeAsync(CustomerSourceInsertRangeDtoRequest request);

    Task<CustomerSourceUpdateDtoResponse> UpdateAsync(CustomerSourceUpdateDtoRequest request);

    Task<CustomerSourceUpdateRangeDtoResponse> UpdateRangeAsync(CustomerSourceUpdateRangeDtoRequest request);

    Task<CustomerSourceDeleteDtoResponse> DeleteAsync(CustomerSourceDeleteDtoRequest request);

    Task<CustomerSourceDeleteRangeDtoResponse> DeleteRangeAsync(CustomerSourceDeleteRangeDtoRequest request);

    Task<CustomerSourceSaveRangeDtoResponse> SaveRangeAsync(CustomerSourceSaveRangeDtoRequest request);
   
}