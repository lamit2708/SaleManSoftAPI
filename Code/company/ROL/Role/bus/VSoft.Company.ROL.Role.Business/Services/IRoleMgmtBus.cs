using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.ROL.Role.Business.Dto.Request;
using VSoft.Company.ROL.Role.Business.Dto.Response;

namespace VSoft.Company.ROL.Role.Business.Services;

public interface IRoleMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByInt request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByInt request);

    RoleFindDtoResponse Find(MDtoRequestFindByInt request);

    Task<RoleFindDtoResponse> FindAsync(MDtoRequestFindByInt request);

    RoleFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request);

    Task<RoleFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request);

    RoleInsertDtoResponse Create(RoleInsertDtoRequest request);

    Task<RoleInsertDtoResponse> CreateAsync(RoleInsertDtoRequest request);

    RoleInsertRangeDtoResponse CreateRange(RoleInsertRangeDtoRequest request);

    Task<RoleInsertRangeDtoResponse> CreateRangeAsync(RoleInsertRangeDtoRequest request);

    RoleUpdateDtoResponse Update(RoleUpdateDtoRequest request);

    Task<RoleUpdateDtoResponse> UpdateAsync(RoleUpdateDtoRequest request);

    RoleUpdateRangeDtoResponse UpdateRange(RoleUpdateRangeDtoRequest request);

    Task<RoleUpdateRangeDtoResponse> UpdateRangeAsync(RoleUpdateRangeDtoRequest request);

    RoleDeleteDtoResponse Delete(RoleDeleteDtoRequest request);

    Task<RoleDeleteDtoResponse> DeleteAsync(RoleDeleteDtoRequest request);

    RoleDeleteRangeDtoResponse DeleteRange(RoleDeleteRangeDtoRequest request);

    Task<RoleDeleteRangeDtoResponse> DeleteRangeAsync(RoleDeleteRangeDtoRequest request);

    Task<RoleSaveRangeDtoResponse> SaveRangeAsync(RoleSaveRangeDtoRequest request);

    Task<RoleSaveRangeDtoResponse> SaveRangeTransactionAsync(RoleSaveRangeDtoRequest request);
}
