using VSoft.Company.ACT.Activity.Business.Dto.Data;
using VSoft.Company.ACT.Activity.Data.Entity.Models;

namespace VSoft.Company.ACT.Activity.Business.entity.Extension.Methods;

public static class ActivityEntityMethods
{
    public static ActivityDto GetDto(this MActivityEntity src)
    {
        return new ActivityDto()
        {
            Id = src.Id,
            Name = src.Name,
            Description = src.Description
        };
    }
}
