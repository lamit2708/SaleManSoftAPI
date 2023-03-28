using VSoft.Company.ROL.Role.Business.Dto.Data;
using VSoft.Company.ROL.Role.Data.Entity.Models;

namespace VSoft.Company.ROL.Role.Business.Dto.Extension.Methods;

public static class RoleDtoMethods
{
    public static MRoleEntity GetEntity(this RoleDto src, bool isForUpdate)
    {
        return new MRoleEntity()
        {
            Id = src.Id,
            Name = src.Name,
            Description = src.Description
        };
    }
}
