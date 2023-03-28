using VSoft.Company.URO.UserRole.Business.Dto.Data;
using VSoft.Company.URO.UserRole.Data.Entity.Models;

namespace VSoft.Company.URO.UserRole.Business.entity.Extension.Methods;

public static class UserRoleEntityMethods
{
    public static UserRoleDto GetDto(this MUserRoleEntity src)
    {
        return new UserRoleDto()
        {
            Id = src.Id,
            RoleId = src.RoleId,
            UserId = src.UserId,
        };
    }
}
