using VSoft.Company.URO.UserRole.Business.Dto.Data;
using VSoft.Company.URO.UserRole.Data.Entity.Models;

namespace VSoft.Company.URO.UserRole.Business.Dto.Extension.Methods;

public static class UserRoleDtoMethods
{
    public static MUserRoleEntity GetEntity(this UserRoleDto src, bool isForUpdate)
    {
        return new MUserRoleEntity()
        {
            Id = src.Id,
            RoleId = src.RoleId,
            UserId = src.UserId,
        };
    }
}
