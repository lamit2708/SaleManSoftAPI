using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.URO.UserRole.Business.Dto.Request;
using VSoft.Company.URO.UserRole.Business.Dto.Response;

namespace VSoft.Company.URO.UserRole.Business.Services;

public interface IUserRoleMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByLong request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByLong request);

    UserRoleFindDtoResponse Find(MDtoRequestFindByLong request);

    Task<UserRoleFindDtoResponse> FindAsync(MDtoRequestFindByLong request);

    UserRoleFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request);

    Task<UserRoleFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request);

    UserRoleInsertDtoResponse Create(UserRoleInsertDtoRequest request);

    Task<UserRoleInsertDtoResponse> CreateAsync(UserRoleInsertDtoRequest request);

    UserRoleInsertRangeDtoResponse CreateRange(UserRoleInsertRangeDtoRequest request);

    Task<UserRoleInsertRangeDtoResponse> CreateRangeAsync(UserRoleInsertRangeDtoRequest request);

    UserRoleUpdateDtoResponse Update(UserRoleUpdateDtoRequest request);

    Task<UserRoleUpdateDtoResponse> UpdateAsync(UserRoleUpdateDtoRequest request);

    UserRoleUpdateRangeDtoResponse UpdateRange(UserRoleUpdateRangeDtoRequest request);

    Task<UserRoleUpdateRangeDtoResponse> UpdateRangeAsync(UserRoleUpdateRangeDtoRequest request);

    UserRoleDeleteDtoResponse Delete(UserRoleDeleteDtoRequest request);

    Task<UserRoleDeleteDtoResponse> DeleteAsync(UserRoleDeleteDtoRequest request);

    UserRoleDeleteRangeDtoResponse DeleteRange(UserRoleDeleteRangeDtoRequest request);

    Task<UserRoleDeleteRangeDtoResponse> DeleteRangeAsync(UserRoleDeleteRangeDtoRequest request);

    Task<UserRoleSaveRangeDtoResponse> SaveRangeAsync(UserRoleSaveRangeDtoRequest request);

    Task<UserRoleSaveRangeDtoResponse> SaveRangeTransactionAsync(UserRoleSaveRangeDtoRequest request);
}
