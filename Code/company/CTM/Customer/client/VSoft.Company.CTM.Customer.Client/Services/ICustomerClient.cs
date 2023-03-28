using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.CTM.Customer.Business.Dto.Request;
using VSoft.Company.CTM.Customer.Business.Dto.Response;

namespace VSoft.Company.CTM.Customer.Client.Services;

public interface ICustomerClient: IApiDtoClientJSon<ICustomerClient>
{  

    Task<CustomerFindDtoResponse> FindAsync(MDtoRequestFindByString request);

    Task<CustomerFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<CustomerInsertDtoResponse> CreateAsync(CustomerInsertDtoRequest request);

    Task<CustomerInsertRangeDtoResponse> CreateRangeAsync(CustomerInsertRangeDtoRequest request);

    Task<CustomerUpdateDtoResponse> UpdateAsync(CustomerUpdateDtoRequest request);

    Task<CustomerUpdateRangeDtoResponse> UpdateRangeAsync(CustomerUpdateRangeDtoRequest request);

    Task<CustomerDeleteDtoResponse> DeleteAsync(CustomerDeleteDtoRequest request);

    Task<CustomerDeleteRangeDtoResponse> DeleteRangeAsync(CustomerDeleteRangeDtoRequest request);

    Task<CustomerSaveRangeDtoResponse> SaveRangeAsync(CustomerSaveRangeDtoRequest request);
   
}