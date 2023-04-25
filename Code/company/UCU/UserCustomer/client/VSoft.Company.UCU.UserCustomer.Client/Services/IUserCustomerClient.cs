using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.UCU.UserCustomer.Business.Dto.Request;
using VSoft.Company.UCU.UserCustomer.Business.Dto.Response;

namespace VSoft.Company.UCU.UserCustomer.Client.Services;

public interface IUserCustomerClient: IApiDtoClientJSon<IUserCustomerClient>
{
    Task<UserCustomerFindDtoResponse> FindAsync(MDtoRequestFindByInt request);

    Task<UserCustomerFindDtoResponse> FindAsync(MDtoRequestFindByString request);

    Task<UserCustomerFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<UserCustomerInsertDtoResponse> CreateAsync(UserCustomerInsertDtoRequest request);

    Task<UserCustomerInsertRangeDtoResponse> CreateRangeAsync(UserCustomerInsertRangeDtoRequest request);

    Task<UserCustomerUpdateDtoResponse> UpdateAsync(UserCustomerUpdateDtoRequest request);

    Task<UserCustomerUpdateRangeDtoResponse> UpdateRangeAsync(UserCustomerUpdateRangeDtoRequest request);

    Task<UserCustomerDeleteDtoResponse> DeleteAsync(UserCustomerDeleteDtoRequest request);

    Task<UserCustomerDeleteRangeDtoResponse> DeleteRangeAsync(UserCustomerDeleteRangeDtoRequest request);

    Task<UserCustomerSaveRangeDtoResponse> SaveRangeAsync(UserCustomerSaveRangeDtoRequest request);
	Task<UserCustomerTableKeySearchDtoResponse> GetTableByKeyword(UserCustomerTableKeySearchDtoRequest request);
}