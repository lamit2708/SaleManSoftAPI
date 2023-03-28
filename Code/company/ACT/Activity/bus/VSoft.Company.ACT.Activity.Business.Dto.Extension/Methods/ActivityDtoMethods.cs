using VSoft.Company.ACT.Activity.Business.Dto.Data;
using VSoft.Company.ACT.Activity.Data.Entity.Models;

namespace VSoft.Company.ACT.Activity.Business.Dto.Extension.Methods;

public static class ActivityDtoMethods
{
    public static MActivityEntity GetEntity(this ActivityDto src, bool isForUpdate)
    {
        return new MActivityEntity()
        {
            Id = src.Id,
            Name = src.Name,
            Description = src.Description
        };
    }
}
