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
            Content = src.Content,
            ActivityType = src.ActivityType,
            Date = src.Date,
            From = src.From,
            To = src.To,
            ToWho = src.ToWho,  
            SubType = src.SubType,
            CreatedDate = src.CreatedDate,
            CreatedUser = src.CreatedUser,  
        };
    }
}
