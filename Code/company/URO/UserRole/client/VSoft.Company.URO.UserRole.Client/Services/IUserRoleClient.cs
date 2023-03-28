using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.URO.UserRole.Business.Dto.Request;
using VSoft.Company.URO.UserRole.Business.Dto.Response;

namespace VSoft.Company.URO.UserRole.Client.Services;

public interface IUserRoleClient: IApiDtoClientJSon<IUserRoleClient>
{  

    Task<UserRoleFindDtoResponse> FindAsync(MDtoRequestFindByString request);

    Task<UserRoleFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<UserRoleInsertDtoResponse> CreateAsync(UserRoleInsertDtoRequest request);

    Task<UserRoleInsertRangeDtoResponse> CreateRangeAsync(UserRoleInsertRangeDtoRequest request);

    Task<UserRoleUpdateDtoResponse> UpdateAsync(UserRoleUpdateDtoRequest request);

    Task<UserRoleUpdateRangeDtoResponse> UpdateRangeAsync(UserRoleUpdateRangeDtoRequest request);

    Task<UserRoleDeleteDtoResponse> DeleteAsync(UserRoleDeleteDtoRequest request);

    Task<UserRoleDeleteRangeDtoResponse> DeleteRangeAsync(UserRoleDeleteRangeDtoRequest request);

    Task<UserRoleSaveRangeDtoResponse> SaveRangeAsync(UserRoleSaveRangeDtoRequest request);
   
}