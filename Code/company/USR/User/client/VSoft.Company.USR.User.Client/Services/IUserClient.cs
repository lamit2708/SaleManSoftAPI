using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.USR.User.Business.Dto.Request;
using VSoft.Company.USR.User.Business.Dto.Response;

namespace VSoft.Company.USR.User.Client.Services;

public interface IUserClient: IApiDtoClientJSon<IUserClient>
{  

    Task<UserFindDtoResponse> FindAsync(MDtoRequestFindByString request);

    Task<UserFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<UserInsertDtoResponse> CreateAsync(UserInsertDtoRequest request);

    Task<UserInsertRangeDtoResponse> CreateRangeAsync(UserInsertRangeDtoRequest request);

    Task<UserUpdateDtoResponse> UpdateAsync(UserUpdateDtoRequest request);

    Task<UserUpdateRangeDtoResponse> UpdateRangeAsync(UserUpdateRangeDtoRequest request);

    Task<UserDeleteDtoResponse> DeleteAsync(UserDeleteDtoRequest request);

    Task<UserDeleteRangeDtoResponse> DeleteRangeAsync(UserDeleteRangeDtoRequest request);

    Task<UserSaveRangeDtoResponse> SaveRangeAsync(UserSaveRangeDtoRequest request);
   
}