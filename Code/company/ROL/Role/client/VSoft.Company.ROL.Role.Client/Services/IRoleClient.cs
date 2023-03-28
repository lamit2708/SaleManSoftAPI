using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.ROL.Role.Business.Dto.Request;
using VSoft.Company.ROL.Role.Business.Dto.Response;

namespace VSoft.Company.ROL.Role.Client.Services;

public interface IRoleClient: IApiDtoClientJSon<IRoleClient>
{  

    Task<RoleFindDtoResponse> FindAsync(MDtoRequestFindByString request);

    Task<RoleFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<RoleInsertDtoResponse> CreateAsync(RoleInsertDtoRequest request);

    Task<RoleInsertRangeDtoResponse> CreateRangeAsync(RoleInsertRangeDtoRequest request);

    Task<RoleUpdateDtoResponse> UpdateAsync(RoleUpdateDtoRequest request);

    Task<RoleUpdateRangeDtoResponse> UpdateRangeAsync(RoleUpdateRangeDtoRequest request);

    Task<RoleDeleteDtoResponse> DeleteAsync(RoleDeleteDtoRequest request);

    Task<RoleDeleteRangeDtoResponse> DeleteRangeAsync(RoleDeleteRangeDtoRequest request);

    Task<RoleSaveRangeDtoResponse> SaveRangeAsync(RoleSaveRangeDtoRequest request);
   
}