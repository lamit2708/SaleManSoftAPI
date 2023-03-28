using VSoft.Company.USR.User.Business.Dto.Data;
using VSoft.Company.USR.User.Data.Entity.Models;

namespace VSoft.Company.USR.User.Business.Dto.Extension.Methods;

public static class UserDtoMethods
{
    public static MUserEntity GetEntity(this UserDto src, bool isForUpdate)
    {
        return new MUserEntity()
        {
            Id = src.Id,
            Name = src.Name,
            Phone = src.Phone,
            Email = src.Email,
            Username = src.Username,
            Password = src.Password,
            TeamId = src.TeamId,
           
        };
    }
}
